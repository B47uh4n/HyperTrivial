using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneManagement : MonoBehaviour
{

    //public CoinCollect coincollect;
    public int coinBackup = 0;
    public static bool finishlineControl = false;
    public GameObject PauseMenuUI;
    public GameObject PauseBtn;
    public GameObject Player;

    //sahne ile ilgili seyler yapilacagi zaman bu classtan nesne yaratip burdaki fonksiyonlari kullanacagiz.
    public void NextScene()
    {
        //coincollect = GameObject.Find("PlayerHolder").GetComponent<CoinCollect>();
        //PlayerPrefs.SetInt("coin", coincollect.coin);
        finishlineControl = true;
        coinBackup = PlayerPrefs.GetInt("coinAmount");
        PlayerPrefs.SetInt("coinBackup", coinBackup);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void hoverOver()
    {
        Player.GetComponent<PlayerMovement>().enabled = false;
    }

    public void hoverLeave()
    {
        Player.GetComponent<PlayerMovement>().enabled = true;
    }

    public void PauseButton()
    {
        Player.GetComponent<PlayerMovement>().enabled = false;
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        PauseBtn.SetActive(false);
    }

    public void ResumeButton()
    {
        Player.GetComponent<PlayerMovement>().enabled = true;
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        PauseBtn.SetActive(true);
    }

    public void SelectionButton()
    {
        PlayerPrefs.SetInt("coinAmount", PlayerPrefs.GetInt("coinBackup", 0));
        PlayerPrefs.SetInt("currentSceneIndex", SceneManager.GetActiveScene().buildIndex);
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        SceneManager.LoadScene("CharSelMenu");
    }
}