using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanceTrigger : MonoBehaviour
{

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Animator>().SetBool("dance",true);
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Dancing"))
        {
            GetComponent<Animator>().Play("dance");
            Debug.Log("danset");
        }
        
    }
}
