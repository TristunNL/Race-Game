using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;
using UnityEngine.Rendering;

public class RemoteControl : MonoBehaviour
{
    [Header("Input Variables")]
    public float forwards;
    public float turn;
    CarControllerScript carControllerScript;

    void Awake()
    {
        carControllerScript = GetComponent<CarControllerScript>();
    }

    void Update()
    {
        forwards = Input.GetAxis("Vertical");

        if (Input.GetAxis("Horizontal") != 0)
        {
            turn = Input.GetAxis("Horizontal");
        }

        carControllerScript.changeSpeed(forwards);
        carControllerScript.Turn(turn);
    }
}