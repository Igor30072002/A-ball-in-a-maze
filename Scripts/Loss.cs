using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loss : MonoBehaviour
{
    public timer timer;

    public GameObject lossPanel;

    public AudioClip audioClip;
    public AudioSource audioSource;
    
    private bool oneTime = false;
    void Update()
    {
        if(timer.intTime <= 0)
        {
            if (!oneTime)
            {
                audioSource.clip = audioClip;
                audioSource.Play();
                oneTime = true;
            }
            lossPanel.SetActive(true);
        }
    }
}
