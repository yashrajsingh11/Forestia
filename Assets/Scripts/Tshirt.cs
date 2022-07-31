using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tshirt : MonoBehaviour
{
    Renderer rend;
    public Material[] tshirts;
    private int tshirtIndex;
    // Start is called before the first frame update
    void Start()
    {
        tshirtIndex = 0;
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = tshirts[tshirtIndex];
    }

    // Update is called once per frame
    void Update()
    {
        rend.sharedMaterial = tshirts[tshirtIndex];
    }

    public void change(){
        if(tshirtIndex == tshirts.Length - 1){
            tshirtIndex = 0;
        }
        else{
            tshirtIndex++;
        }
    }

}
