using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameOverMenu GameOverMenu;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("FalseAnswer"))
        {
            GameOverMenu.GameOver();
        }
    }

    
}
