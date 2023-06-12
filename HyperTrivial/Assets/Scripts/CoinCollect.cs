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
        if(other.transform.tag == "Coin")
        {
            coin++;
            coinText.text = "Coin: " + coin.ToString();
            Debug.Log(coin);
            Destroy(other.gameObject);
        }
    }
}
