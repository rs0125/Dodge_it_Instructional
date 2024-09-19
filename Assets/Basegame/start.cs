using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class start : MonoBehaviour
{

    public RawImage startgame;
    public movement movement;

    // Update is called once per frame
    void Update()
    {
        Invoke("startUI", 1F);
    }


    void startUI()
    {
        startgame.enabled = false;
        movement.enabled = true;
    }
}
