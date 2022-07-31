using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobbyController : MonoBehaviourPunCallbacks
{
    void Start()
    {
        
    }

    [SerializeField]
    private GameObject Play;
    [SerializeField]
    private int roomSize;

    public override void OnConnectedToMaster()
    {
        PhotonNetwork.AutomaticallySyncScene = true;
        Play.SetActive(true);
    }

    public void MyStart()
    {
        Play.SetActive(false);
        PhotonNetwork.JoinRandomRoom();
        Debug.Log("Joined A Random Room");
    }

    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        CreateRoom();
    }

    void CreateRoom()
    {
        Debug.Log("Creating Room Now");
        int randomRoomNumber = Random.Range(0, 10000);
        RoomOptions roomOps = new RoomOptions() { IsVisible = true, IsOpen = true, MaxPlayers = (byte)roomSize };
        PhotonNetwork.CreateRoom("Room" + randomRoomNumber, roomOps);
        Debug.Log(randomRoomNumber);
    }

    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        Debug.Log("Failed to create a room. Trying Again");
        CreateRoom();
    }

    void Update()
    {
        
    }
}
