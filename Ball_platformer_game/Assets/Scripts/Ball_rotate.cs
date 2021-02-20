using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_rotate : MonoBehaviour
{
    public GameObject Ball;

    private void Update()
    {
        transform.Rotate(new Vector3(90, 0, 0) * 2 * Time.deltaTime);
    }

}
