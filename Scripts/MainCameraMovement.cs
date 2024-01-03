using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraMovement : MonoBehaviour
{
    private Vector3 startinPoint;
    private float timer;
    void Start()
    {
        timer = 0;
        startinPoint = transform.position;
    }
    void Update()
    {
        transform.position = new Vector3(transform.position.x + 0.1f, transform.position.y, transform.position.z);
        timer += Time.deltaTime;
        if(timer > 30)
        {
            transform.position = startinPoint;
            timer = 0;
        }
    }
}
