using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hair : MonoBehaviour
{
    Renderer rend;
    public Material[] hairs;
    private int hairIndex;
    // Start is called before the first frame update
    void Start()
    {
        hairIndex = 0;
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = hairs[hairIndex];
    }

    // Update is called once per frame
    void Update()
    {
        rend.sharedMaterial = hairs[hairIndex];
    }

    public void skinTone(){
        if(hairIndex == hairs.Length - 1){
            hairIndex = 0;
        }
        else{
            hairIndex++;
        }
    }
}
