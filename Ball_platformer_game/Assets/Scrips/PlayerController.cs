using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public float force;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 movement = new Vector3(0.0f, 0.0f, 1.0f);
        rb.AddForce(movement*force);
        //apply force to keep the ball moving
    }

    private void Update()
    {
        if (Input.GetKey("a")) {Debug.Log("left"); }
        if (Input.GetKey("s")) { Debug.Log("middle"); }
        if (Input.GetKey("d")) { Debug.Log("right"); }
    }
}
