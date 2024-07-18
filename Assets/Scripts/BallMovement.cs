using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] float bounceForce = 500f;

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        //var zForce = 10f;
        rb.AddRelativeForce(30f, 0f, bounceForce);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("OnCollisionEnter");

        if(!(other.gameObject.tag == "Player" || other.gameObject.tag == "Wall")) return;


        var rbBall = GetComponent<Rigidbody>();
            
        //get ball movement vector
        var ballVector = other.relativeVelocity;
        Debug.Log(ballVector);

        if(Mathf.Abs(ballVector.z) > Mathf.Abs(ballVector.x))
        {
            rbBall.AddRelativeForce(-ballVector.x, 0f, -bounceForce);
        }
        else
        {
            rbBall.AddRelativeForce(-bounceForce, 0f, -ballVector.z);
        }

        
        //var newVector = 

        //rbBall.AddRelativeForce(ballVector.x * 2, 0f, -ballVector.z * 2);


        //rbBall.AddRelativeForce(0f, 0f, -300f);


        // if(other.gameObject.tag == "Ball") // "other.gameObject" is the object you collided on
        // {
        //     //GetComponent<MeshRenderer>().material.color = Color.blue;
            
        //     // get ball object
        //     var ball = other.gameObject;
        //     var rbBall = ball.GetComponent<Rigidbody>();
            
        //     // get ball movement vector
        //     // var ballVector = other.relativeVelocity;
            
        //     // reflect vector
        //     // Makes the reflected object appear opposite of the original object,
        //     // mirrored along the z-axis of the world
        //     // var reflectedVector = Vector3.Reflect(ballVector, Vector3.up);


        //     rbBall.AddRelativeForce(0f, 0f, -300f);
        //     //rbBall.AddRelativeForce(reflectedVector);
            
        //     Debug.Log(ball.name);
            
        //     //gameObject.tag = "Hit"; // gameObject is the object which this script belongs
        // }
    }    
}
