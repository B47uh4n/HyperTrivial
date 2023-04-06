using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    public GameObject GameOverMenuUI;
    public GameObject Player;

    public void GameOver()
    {
        //bu fonksiyona score parametresi istenebilir
        GameOverMenuUI.SetActive(true);
        //true yaparak actigimiz paneldeki bir textin icine parametreden aldigimiz score eklenebilir.
        //boylece gameover fonk. biyerden cagirdigimizda parametre olarak o anki score degiskenini veririz direkt ekranda o gozukur.
        Time.timeScale = 0f;
        Player.GetComponent<PlayerMovement>().enabled = false;
    }

    public void RestartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }
}
