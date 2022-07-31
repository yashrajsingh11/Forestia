using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avatar : MonoBehaviour
{
    public GameObject[] avatars;
    private int currentAvatar;
    public GameObject customizeMenu;
    public GameObject selectionMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for(int i=0; i<avatars.Length; i++){
            if(i == currentAvatar){
                avatars[i].SetActive(true);
            
            }
            else{
                avatars[i].SetActive(false);
            }
        }
    }

    public void next(){
        if(currentAvatar == avatars.Length - 1){
            currentAvatar = 0;
        }
        else
        {
            currentAvatar++;
        }
    }

    public void prev(){
        if(currentAvatar == 0){
            currentAvatar = avatars.Length - 1;
        }
        else{
            currentAvatar--;
        }
    }

    public void chnageCanvas(){
        selectionMenu.SetActive(false);
        customizeMenu.SetActive(true);
    }

    public void back(){
        customizeMenu.SetActive(false);
        selectionMenu.SetActive(true);
    }

}
