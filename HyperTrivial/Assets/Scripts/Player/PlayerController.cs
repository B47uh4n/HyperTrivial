using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlayerController : MonoBehaviour
{
    public GameOverMenu GameOverMenu;
    public SceneManagement SceneManager;
    public Animator anim;
    [SerializeField] Transform Cam;
    [SerializeField] GameObject Confetti;
    [SerializeField] GameObject FinishPanel;
    [SerializeField] AudioSource TrueVoice;
    [SerializeField] AudioSource FalseVoice;
    [SerializeField] AudioSource victory;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("FalseAnswer"))
        { 
            FalseVoice.Play();
            GameOverMenu.GameOver();
           
        }
        else if (other.CompareTag("TrueAnswer"))
        {
            TrueVoice.Play();
        }
        else if (other.CompareTag("NextScene"))
        {
            SceneManager.NextScene();
        }
        else if (other.CompareTag("Dancing"))
        {
            victory.Play();
            if (PlayerPrefs.GetInt("selectedCharacter") == 0 || PlayerPrefs.GetInt("selectedCharacter") == 1 || PlayerPrefs.GetInt("selectedCharacter") == 2)
            {
                anim = GetComponentInChildren<Animator>();
                anim.Play("dance");
                //Cam.DOMove(new Vector3(35.0f, -9.5f, 156.5f), 5.0f);
                //Cam.DORotate(new Vector3(20.9f, -106.8f, -5.0f), 5.0f);
                Cam.GetComponent<CameraHolder>().enabled = false;
                Cam.DOMove(new Vector3(0.9f, -1.5f, 157.0f), 5.0f);
                Cam.DORotate(new Vector3(5.46f, -118.5f, 0.1f), 5.0f);
                Confetti.SetActive(true);
                FinishPanel.SetActive(true);
            }
            
        }
    }



}
