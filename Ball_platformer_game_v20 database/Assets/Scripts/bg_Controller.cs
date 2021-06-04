using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bg_Controller : MonoBehaviour
{
    GameObject bg;
    private void Start()
    {
        bg = new GameObject();
        
    }

    void OnTriggerEnter(Collider e)
    {
        
        if (e.CompareTag("Player"))
        {


            if (gameObject.transform.parent.CompareTag("bg2"))
            {
                
                bg = GameObject.FindGameObjectWithTag("bg1");
                bg.transform.position = new Vector3(0, 0, bg.transform.position.z + 400);
            }
            else
            {
                bg = GameObject.FindGameObjectWithTag("bg2");
                bg.transform.position = new Vector3(0, 0, bg.transform.position.z + 400);
               
            }

        }
    }
}
