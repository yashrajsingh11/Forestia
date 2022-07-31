using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomController : MonoBehaviourPunCallbacks
{
    void Start()
    {
        
    }

    [SerializeField]
    private int waitingRoomSceneIndex = 2;

    public override void OnEnable()
    {
        PhotonNetwork.AddCallbackTarget(this);
    }

    public override void OnDisable()
    {
        PhotonNetwork.RemoveCallbackTarget(this);
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel(waitingRoomSceneIndex);
    }

    void Update()
    {
        
    }
}
