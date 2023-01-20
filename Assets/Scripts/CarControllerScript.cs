using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class CarControllerScript : MonoBehaviour
{
    [Header("basic car variables")]
    public float maxSpeed = 20; // hier wordt de maximale snelheid die de auto mag rijden aan gegeven 
    public float turnSpeed = 100; // hier wordt de snelheid gezet voor de raaisnelhied gezet 
    public float accel = 5f;
    public float drivingSpeed = 0;
    public float Brake = 0.98f;
    public int checkPointCounter = 0;
    Rigidbody rb;
    public GameObject[] checkPoints;
    public GameObject currentCeckPoint;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        //var pos = new Vector3(0, -1, 0);
        //rb.centerOfMass = pos;
    }
    public void Turn(float direction)
    {
        transform.Rotate(0, direction * turnSpeed * Time.deltaTime, 0);

    }
    public void changeSpeed(float throttle)
    {
        float forwardSpeed = Vector3.Dot(transform.forward, rb.velocity);
        if (forwardSpeed < maxSpeed && forwardSpeed > -maxSpeed)
        {
            if (throttle != 0)
            {
                drivingSpeed = drivingSpeed + accel * throttle * Time.deltaTime;
                drivingSpeed = Mathf.Clamp(drivingSpeed, -maxSpeed, maxSpeed);
            }
            else
            {
                drivingSpeed = Mathf.Lerp(drivingSpeed, 0, Time.deltaTime);
            }

            Vector3 velocity = Vector3.forward * drivingSpeed;
            //transform.Translate(velocity * Time.deltaTime, Space.Self);
            rb.AddRelativeForce(velocity, ForceMode.Force);
        }

        //if (throttle != 0)
        //{
        //    drivingSpeed = drivingSpeed + accelerate * throttle * Time.deltaTime;
        //    drivingSpeed = Mathf.Clamp(drivingSpeed, -maxSpeed, maxSpeed);
        //}
        //else
        //{
        //    drivingSpeed = Mathf.Lerp(drivingSpeed, 0, Time.deltaTime);

        //}
        //Vector3 velocity = Vector3.forward * drivingSpeed;
        //transform.Translate(velocity * Time.deltaTime, Space.Self);
    }
}


// press s = stoppen 

