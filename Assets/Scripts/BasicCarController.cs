using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicCarController : MonoBehaviour
{
    [Header("Basic Car Variables")]
    public float maxSpeed = 10;
    public float turnSpeed = 50;
    public float accel = 2.5f;
    public float speed = 0;

    [Header("Level Variables")]
    //we maken een array; een lijst van gameobjects
    public GameObject[] checkPoints;
    public GameObject currentCheckPoint;
    public int checkPointCounter = 0;
    Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void ChangeSpeed(float throttle)
    {
        float forwardSpeed = Vector3.Dot(transform.forward, rb.velocity);
        if (forwardSpeed < maxSpeed && forwardSpeed > -maxSpeed) 
        {
            if (throttle != 0)
            {
                speed = speed + accel * throttle * Time.deltaTime;
                speed = Mathf.Clamp(speed, -maxSpeed, maxSpeed);
            }
            else
            {
                 speed = Mathf.Lerp(speed, 0, Time.deltaTime);
            }
        
            Vector3 velocity = Vector3.forward * -speed;
            //transform.Translate(velocity * Time.deltaTime, Space.Self);
            rb.AddRelativeForce(velocity, ForceMode.Force);
        }

    }

    public void Turn(float direction)
    {

        transform.Rotate(0, direction * -turnSpeed * Time.deltaTime, 0);
    }

    public GameObject NextCheckpoint()
    {
        checkPointCounter++;
        if (checkPointCounter > checkPoints.Length - 1)
        {
            checkPointCounter = 0;
        }
        currentCheckPoint = checkPoints[checkPointCounter];
        return currentCheckPoint;
    }


}
