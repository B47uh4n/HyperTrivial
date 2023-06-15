using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class FinishManager : MonoBehaviour
{
    [SerializeField] GameObject names;
    [SerializeField] GameObject FinishPanel;
    [SerializeField] GameObject CreditsPanel;
    [SerializeField] Transform Cam;

    public void credits()
    {
        FinishPanel.SetActive(false);
        CreditsPanel.SetActive(true);
        Cam.GetComponent<CameraHolder>().enabled = false;
        Cam.DOMove(new Vector3(-7.0f, 2.3f, 153.0f), 5.0f);
        Cam.DORotate(new Vector3(-31.5f, 45.5f, 0.1f), 5.0f);
    } 
}
