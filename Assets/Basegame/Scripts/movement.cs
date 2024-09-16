using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class movement : MonoBehaviour
{
    public Rigidbody rb;
    public float ForwardForce = 2000f;
    public float KeySideForce = 500f;
    public float ButtonSideForce = 500f;
    public MyButton left;
    public MyButton right;



    // Update is called once per frame
    void FixedUpdate()
    {
        //adds a forward force
        rb.AddForce(0, 0, ForwardForce * Time.deltaTime);



        // keyboard input (non touch screen)
        if (Input.GetKey("d"))
        {
            rb.AddForce(KeySideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-KeySideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }


        // button input (touchscreen)
        if (right.isPressed)
        {
            rb.AddForce(ButtonSideForce * Time.deltaTime, 0, 0);
        }


        if (left.isPressed)
        {
            rb.AddForce(-ButtonSideForce * Time.deltaTime, 0, 0);
        }


        // if the object is below the position of y axis = -1, end the game
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}