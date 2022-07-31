using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sneakers : MonoBehaviour
{
    Renderer rend;
    public Material[] sneakers;
    private int sneakerIndex;
    // Start is called before the first frame update
    void Start()
    {
        sneakerIndex = 0;
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = sneakers[sneakerIndex];
    }

    // Update is called once per frame
    void Update()
    {
        rend.sharedMaterial = sneakers[sneakerIndex];
    }

    public void skinTone(){
        if(sneakerIndex == sneakers.Length - 1){
            sneakerIndex = 0;
        }
        else{
            sneakerIndex++;
        }
    }
}
