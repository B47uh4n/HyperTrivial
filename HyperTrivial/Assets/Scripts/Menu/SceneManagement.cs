using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{

    public CoinCollect coincollect;
    //sahne ile ilgili seyler yapilacagi zaman bu classtan nesne yaratip burdaki fonksiyonlari kullanacagiz.
    public void NextScene()
    {
        //coincollect = GameObject.Find("PlayerHolder").GetComponent<CoinCollect>();
        //PlayerPrefs.SetInt("coin", coincollect.coin);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
