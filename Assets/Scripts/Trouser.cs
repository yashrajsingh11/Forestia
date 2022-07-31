using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trouser : MonoBehaviour
{
    Renderer rend;
    public Material[] trousers;
    private int trouserIndex;
    // Start is called before the first frame update
    void Start()
    {
        trouserIndex = 0;
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = trousers[trouserIndex];
    }

    // Update is called once per frame
    void Update()
    {
        rend.sharedMaterial = trousers[trouserIndex];   
    }

    public void skinTone(){
        if(trouserIndex == trousers.Length - 1){
            trouserIndex = 0;
        }
        else{
            trouserIndex++;
        }
    }
}
