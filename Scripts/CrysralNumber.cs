using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrysralNumber : MonoBehaviour
{
    public Text crystalNumberText;
    private int number;
    public AudioClip audioClip;
    public AudioSource audioSource;

    void Start()
    {
        number = 0;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 8)
        {
            audioSource.clip = audioClip;
            audioSource.Play();
            other.gameObject.SetActive(false);
            number++;
        }
    }

    void Update()
    {
        crystalNumberText.text = number.ToString();
    }
}
