using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class CharacterSelection : MonoBehaviour
{
    public GameObject[] characters;
    public GameObject KratosPriceInfo;
    public int selectedCharacter = 0;

    public void NextCharacter()
    {
        characters[selectedCharacter].SetActive(false);
        selectedCharacter = (selectedCharacter + 1) % characters.Length;
        characters[selectedCharacter].SetActive(true);

        if(selectedCharacter == 1)
        {
            KratosPriceInfo.SetActive(true);
        }
        else
        {
            KratosPriceInfo.SetActive(false);
        }

        characters[selectedCharacter].transform.DOMoveX(14f,2f).From();
    }

    public void PreviousCharacter()
    {
        characters[selectedCharacter].SetActive(false);
        selectedCharacter--;
        if (selectedCharacter < 0)
        {
            selectedCharacter += characters.Length;
        }
        characters[selectedCharacter].SetActive(true);

        if (selectedCharacter == 1)
        {
            KratosPriceInfo.SetActive(true);
        }
        else
        {
            KratosPriceInfo.SetActive(false);
        }

        characters[selectedCharacter].transform.DOMoveX(14f, 2f).From();
    }

    public void StartGame()
    {
        if(selectedCharacter == 0)
        {
            PlayerPrefs.SetInt("selectedCharacter", selectedCharacter);
            SceneManager.LoadScene(1, LoadSceneMode.Single);
        }
        else if(selectedCharacter == 1)
        {
            if(PlayerPrefs.GetInt("coinAmount", 0) >= 130)
            {
                PlayerPrefs.SetInt("selectedCharacter", selectedCharacter);
                SceneManager.LoadScene(1, LoadSceneMode.Single);
            }
        }
        
    }

    public void ReturnTheGame()
    {
        if (selectedCharacter == 0)
        {
            PlayerPrefs.SetInt("selectedCharacter", selectedCharacter);
            SceneManager.LoadScene(PlayerPrefs.GetInt("currentSceneIndex"), LoadSceneMode.Single);
        }
        else if (selectedCharacter == 1)
        {
            if (PlayerPrefs.GetInt("coinAmount", 0) >= 130)
            {
                PlayerPrefs.SetInt("selectedCharacter", selectedCharacter);
                SceneManager.LoadScene(PlayerPrefs.GetInt("currentSceneIndex"), LoadSceneMode.Single);
            }
        }
        
        
    }

}
