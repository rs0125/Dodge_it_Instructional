using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float ForwardForce = 50f;
    public float KeySideForce = 50f;
    public float ButtonSideForce = 50f;
    public MyButton left;
    public MyButton right;


    // Update is called once per frame
    void FixedUpdate()
    {
        //adds a forward force
        rb.AddForce(transform.forward * ForwardForce * Time.deltaTime, ForceMode.VelocityChange);



        if (Input.GetKey("d"))
        {
            rb.AddForce(transform.right * KeySideForce * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-transform.right * KeySideForce * Time.deltaTime, ForceMode.VelocityChange);
        }


        if (right.isPressed)
        {
            rb.AddForce(transform.right * KeySideForce * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (left.isPressed)
        {
            rb.AddForce(-transform.right * KeySideForce * Time.deltaTime, ForceMode.VelocityChange);
        }



        if (transform.localPosition.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}