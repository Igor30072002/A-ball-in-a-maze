using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    private Text textTimer;
    [SerializeField] private float time;
    public GameObject ball;
    public int intTime;
    void Start()
    {
        textTimer = GetComponent<Text>();
        intTime = (int)time;
        textTimer.text = intTime.ToString();
    }
    void Update()
    {
        time -= Time.deltaTime;
        intTime = (int)time;
        if (intTime <= 10)
        {
            textTimer.color = Color.red;
            textTimer.fontSize = 70;
        }
        if (intTime <= 0)
        {
            ball.SetActive(false);
            textTimer.gameObject.SetActive(false);
        }
        textTimer.text = intTime.ToString();
    }
}
