using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving : MonoBehaviour
{
    public float speed;
    void Update()
    {
        Move();
    }

    private Vector2 IsThereTouch()
    {
        if (Input.touchCount > 0)
        {
            return Input.GetTouch(0).deltaPosition;
        }
        else return Vector2.zero;
    }

    private void Move()
    {
        Physics.gravity = new Vector3(IsThereTouch().x * speed, Physics.gravity.y, IsThereTouch().y * speed);
    }
}
