using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    //sahne ile ilgili seyler yapilacagi zaman bu classtan nesne yaratip burdaki fonksiyonlari kullanacagiz.
    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
