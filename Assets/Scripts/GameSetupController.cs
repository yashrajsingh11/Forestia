using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using System.IO;
using Cinemachine;

public class GameSetupController : MonoBehaviourPun
{
    [SerializeField] private GameObject playerPrefab = null;
    [SerializeField] private CinemachineFreeLook playerCamera = null;

    void Start()
    {
        var player = PhotonNetwork.Instantiate(playerPrefab.name, Vector3.zero, Quaternion.identity);
        playerCamera.Follow = player.transform;
        playerCamera.LookAt = player.transform;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
