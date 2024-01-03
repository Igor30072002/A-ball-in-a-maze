using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victory : MonoBehaviour
{
    private GameObject ball;
    [SerializeField] private GameObject victoryPanel;
    public AudioClip audioClip;
    public AudioSource audioSource;
    void Start()
    {
        ball = GetComponent<GameObject>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Finish")
        {
            audioSource.clip = audioClip;
            audioSource.Play();
            Time.timeScale = 0;
            victoryPanel.SetActive(true);
        }
    }
}
