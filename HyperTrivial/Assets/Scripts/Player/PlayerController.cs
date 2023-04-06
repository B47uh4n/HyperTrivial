using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameOverMenu GameOverMenu;
    public SceneManagement SceneManager;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("FalseAnswer"))
        {
            GameOverMenu.GameOver();
        }
        else if (other.CompareTag("NextScene"))
        {
            SceneManager.NextScene();
        }
    }



}
