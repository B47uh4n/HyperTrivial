using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;

public class MainMenuCam : MonoBehaviour
{
    [SerializeField] private float duration;
    public TextMeshProUGUI coinText;

    public void LookAt(Transform target) 
    {
        transform.DOLookAt(target.position, duration);
        coinText.text = "Coin: " + PlayerPrefs.GetInt("coinAmount", 0).ToString();
    }
}
