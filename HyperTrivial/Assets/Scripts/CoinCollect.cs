using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinCollect : MonoBehaviour
{

    public int coin = 0;
    public TextMeshProUGUI coinText;



    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Coin")
        {
            coin = PlayerPrefs.GetInt("coinAmount", 0);
            coin++;
            PlayerPrefs.SetInt("coinAmount", coin);
            coinText.text = "Coin: " + PlayerPrefs.GetInt("coinAmount").ToString();
            Debug.Log(coin);
            Destroy(other.gameObject);
        }
    }

    private void Start()
    {
        coinText.text = "Coin: " + PlayerPrefs.GetInt("coinAmount").ToString();
    }

}
