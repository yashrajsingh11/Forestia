using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class body : MonoBehaviour
{
    Renderer rend;
    public Material[] skins;
    private int skinIndex;
    // Start is called before the first frame update
    void Start()
    {
        skinIndex = 0;
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = skins[skinIndex];
    }

    // Update is called once per frame
    void Update()
    {
        rend.sharedMaterial = skins[skinIndex];
    }

    public void skinTone(){
        if(skinIndex == skins.Length - 1){
            skinIndex = 0;
        }
        else{
            skinIndex++;
        }
    }
}
