using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public float force;

    public Transform start;
    public Transform left;
    public Transform right;
    public Transform middle;
    public float speed;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    //Apply force to make the ball contineously moving, speed can be changed by the public vatriable speed
    void FixedUpdate()
    {
        Vector3 movement = Vector3.forward;
        rb.AddForce(movement * force);

        //apply force to keep the ball moving
    }


    //when input"a" the ball will move to the Left lanes, input"s" will move to the middle lanes, input "d"will move to right lanes
    //When we use kinect can just change the input, relate it to 3 movement
    private void Update()
    {
        if (Input.GetKey("a"))
        {
            transform.position = Vector3.MoveTowards(start.position, left.position, speed * Time.deltaTime);
            //Debug.Log("left"); 
        }
        if (Input.GetKey("s"))
        {
            transform.position = Vector3.MoveTowards(start.position, middle.position, speed * Time.deltaTime);
            //Debug.Log("middle"); 
        }
        if (Input.GetKey("d"))
        {
            transform.position = Vector3.MoveTowards(start.position, right.position, speed * Time.deltaTime);
            //Debug.Log("right");
        }
    }
}
