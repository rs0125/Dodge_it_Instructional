using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{

    public Transform player;
    public TextMeshProUGUI scoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = player.position.z.ToString("0");
    }
}
