using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicCarController : MonoBehaviour
{
    public float maxSpeed = 10;
    public float turnSpeed = 50;
    public float accel = 2.5f;
    public float speed = 0;

    // Start is called before the first frame update
    public void ChangeSpeed(float throttle)
    {
       if (throttle != 0)
        {
            speed = speed + accel * throttle * Time.deltaTime;
            speed = Mathf.Clamp(speed, -maxSpeed, maxSpeed);
            Vector2 velocity = Vector2.up * speed;
            transform.Translate(velocity * Time.deltaTime, Space.Self);
        }
    }

    // Update is called once per frame
    public void Turn(float direction)
    {
        transform.Rotate(0,0, direction * -turnSpeed * Time.deltaTime);
    }
}
