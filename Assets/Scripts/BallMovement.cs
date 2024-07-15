using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        //var zForce = 10f;
        rb.AddRelativeForce(10f, 0f, 300f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
