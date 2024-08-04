using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    private bool inTrigger=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if (inTrigger){
            Debug.Log("Enemy dans zone");
            
        }   
    }


    void OnTriggerEnter2D(Collider2D truc)
    {
        if (truc.tag == "Enemy") {
            inTrigger = true;
        }
    }

    void OnTriggerExit2D(Collider2D truc)
    {
        if (truc.tag == "Enemy") {
            inTrigger = false;
        }
    }
}
