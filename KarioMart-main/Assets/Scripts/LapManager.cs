using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LapManager : MonoBehaviour
{
    public List<Checkpoint> checkpoints;
    public int totalLaps;
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerController>()) 
        {
           // Debug.Log("found playercontroller");
            PlayerController player = collision.gameObject.GetComponent<PlayerController>();
            if (player.checkpointIndex == checkpoints.Count)
            {
                //Debug.Log("checkponint reset works");
                player.checkpointIndex = 0;
                player.lapNumber++;
                

                if (player.lapNumber > totalLaps)
                {
                    // change to scenemanager scene ++ once you have created next scene
                    Debug.Log("you win");

                    if (SceneManager.GetActiveScene().buildIndex >= 3)
                    {
                        SceneManager.LoadScene("MainMenu");
                    }
                    else
                    {
                        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                    }
                }
            }
        }
    }

}
