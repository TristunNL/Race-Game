using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Camera camera1;
    public Camera camera2;
    public Camera camera3;
    public Camera camera4;

    // ai auto's 

    public Camera camera5;
    public Camera camera6;
    public Camera camera7;
    public Camera camera8;
    public Camera camera9;
    public Camera camera10;

    void Start()
    {
        camera1.enabled = true;
        camera2.enabled = false;
        camera3.enabled = false;
        camera4.enabled = false;

        camera5.enabled = false;
        camera6.enabled = false;
        camera7.enabled = false;
        camera8.enabled = false;
        camera9.enabled = false;
        camera10.enabled = false;
    }

    void Update()
    {
        // Player camera's
        if (Input.GetKeyDown(KeyCode.C))
        {
            camera1.enabled = !camera1.enabled;
            camera2.enabled = !camera2.enabled;
            camera3.enabled = !camera3.enabled;
        }

        // Map camera 
        if (Input.GetKeyDown(KeyCode.M))
        {
            camera4.enabled = !camera4.enabled;
        }

        // Player en 5 ai camera's
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            camera5.enabled = !camera5.enabled;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            camera6.enabled = !camera6.enabled;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            camera7.enabled = !camera7.enabled;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            camera8.enabled = !camera8.enabled;
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            camera9.enabled = !camera9.enabled;
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            camera10.enabled = !camera10.enabled;
        }
    }
}