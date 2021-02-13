using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marker_Control : MonoBehaviour
{
    public Transform ball;


   
    // Update is called once per frame
    void Update()
    {

        transform.position = Vector3.forward * ball.position.z + Vector3.up * 0.5f;

    }
}
