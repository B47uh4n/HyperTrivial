using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    public GameObject GameOverMenuUI;
    public GameObject Player;
    int coinCheck;
    //public CoinCollect coincollect;

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
        //coincollect = GameObject.Find("PlayerHolder").GetComponent<CoinCollect>();
        //coincollect.coin = coincollect.firstCoinAmount;
        if (SceneManagement.finishlineControl == false)
        {
            coinCheck = 0;
            PlayerPrefs.SetInt("coinAmount", coinCheck);
        }
        else if (SceneManagement.finishlineControl == true)
        {
            coinCheck = PlayerPrefs.GetInt("coinBackup");
            PlayerPrefs.SetInt("coinAmount", coinCheck);
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }
}