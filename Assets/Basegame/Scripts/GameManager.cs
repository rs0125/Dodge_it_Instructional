using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool gameended = false;
    public void EndGame()
    {

        if (!gameended) {
            gameended = true;
            Debug.Log("game over");

            Invoke("Restart", 2F);
        }
        
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
   }

