using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class NetworkController : MonoBehaviourPunCallbacks
{
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    void Update()
    {
        
    }

    public override void OnConnectedToMaster()
    { 
        Debug.Log("We are connected to " + PhotonNetwork.CloudRegion + " server");
    }

    public void exitGame() {  
        Debug.Log("exitgame");  
        Application.Quit();  
    }

    public void avatarMenu() {  
        SceneManager.LoadScene("Avatar");  
    }
}
