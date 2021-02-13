using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp_Rotate : MonoBehaviour
{
    public GameObject Ball;
    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
        //if ball position.z>pick up position
        if (transform.position.z < (Ball.transform.position.z - 2))
        {
            transform.position += Vector3.forward * 400;
        }
    }
}
