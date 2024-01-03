using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClick : MonoBehaviour
{
    public AudioClip audioClip;
    public AudioSource audioSource;

    public void Click()
    {
        audioSource.clip = audioClip;
        audioSource.Play();
    }
}
