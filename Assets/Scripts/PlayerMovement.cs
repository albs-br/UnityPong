using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float playerSpeed = 10f;
    // [SerializeField] float rotationThrust = 50f;
    Rigidbody rb;
    //AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInput();
    }

    private void ProcessInput()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            // var xForce = playerSpeed * Time.deltaTime;
            // rb.AddRelativeForce(xForce, 0f, 0f);

            float xValue = 1 * Time.deltaTime * playerSpeed;
            // float zValue = 0f; //Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
            // float yValue = 0f;
            transform.Translate(xValue, 0f, 0f);

            // if(!audioSource.isPlaying)
            // {
            //     audioSource.Play();
            // }

            //rb.AddRelativeForce(Vector3.right);

            // Debug.Log("pressed A");
        }
        // else
        // {
        //     //audioSource.Stop();
        // }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            // var xForce = playerSpeed * Time.deltaTime;
            // rb.AddRelativeForce(xForce, 0f, 0f);

            float xValue = -1 * Time.deltaTime * playerSpeed;
            // float zValue = 0f; //Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
            // float yValue = 0f;
            transform.Translate(xValue, 0f, 0f);

            // if(!audioSource.isPlaying)
            // {
            //     audioSource.Play();
            // }

            //rb.AddRelativeForce(Vector3.right);

            // Debug.Log("pressed A");
        }

    }

    // private void ProcessRotation()
    // {
    //     if (Input.GetKey(KeyCode.A))
    //     {
    //         ApplyRotation(rotationThrust);

    //         //Debug.Log("rotating left");
    //     }
    //     else if (Input.GetKey(KeyCode.D))
    //     {
    //         ApplyRotation(-rotationThrust);
            
    //         // Debug.Log("rotating right");
    //     }
    // }

    // private void ApplyRotation(float rotationThisFrame)
    // {
    //     rb.freezeRotation = true; // freezing rotation so we can manually rotate
    //     transform.Rotate(Vector3.forward * rotationThisFrame * Time.deltaTime);
    //     rb.freezeRotation = false; // unfreezing rotation so the physics system can take over
    // }
}
