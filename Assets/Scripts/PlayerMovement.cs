using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : MonoBehaviourPun
{
    [SerializeField] private float movementSpeed = 0f;
    [SerializeField] private Animator animator = null;
    private CharacterController controller = null;
    private Transform mainCameraTransform = null;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        mainCameraTransform = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(photonView.IsMine) 
        {
            TakeInput();
        }
    }

    private void TakeInput()
    {
        var movement = new Vector3 
        {
            x = Input.GetAxisRaw("Horizontal"),
            y = 0f,
            z = Input.GetAxisRaw("Vertical")
        }.normalized;
        Vector3 forward = mainCameraTransform.forward;
        Vector3 right = mainCameraTransform.right;

        forward.y = 0f;
        right.y = 0f;
        forward.Normalize();
        right.Normalize();

        Vector3 calculatedMovement = (forward * movement.z + right * movement.x).normalized;
        controller.SimpleMove(calculatedMovement * movementSpeed);
        if(controller.velocity.magnitude > 0.2f) 
        {
            transform.rotation = Quaternion.LookRotation(calculatedMovement);
        }
        animator.SetBool("isWalking", controller.velocity.magnitude > 0.2f);
    }
}
