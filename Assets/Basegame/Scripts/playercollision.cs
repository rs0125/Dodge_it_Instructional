using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercollision : MonoBehaviour {

    public movement move;
    public Rigidbody rb;
    int backwardforce = 50;

    int count = 0;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            count += 1;
            rb.AddForce(0, 0, -backwardforce, ForceMode.VelocityChange);
            backwardforce -= 15;

        }

        if (count >= 4)
        {
            move.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
