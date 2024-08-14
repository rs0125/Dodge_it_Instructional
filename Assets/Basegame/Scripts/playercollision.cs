using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercollision : MonoBehaviour {

    public movement move;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            move.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
