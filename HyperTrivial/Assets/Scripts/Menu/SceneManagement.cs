using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{

    public CoinCollect coincollect;
    public int coinBackup = 0;
    public static bool finishlineControl = false;

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
}