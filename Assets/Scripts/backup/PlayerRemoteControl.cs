using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRemoteControl : MonoBehaviour
{
    public float forward;
    public float turn;

    BasicCarController BasicCarController;

    void Awake ()
    {
        BasicCarController = GetComponent<BasicCarController>();
    }

    void Update()
    {
        if (Input.GetAxis("Vertical") != 0)
        {
            forward = Input.GetAxis("Vertical");
        }

        if (Input.GetAxis("Horizontal") != 0)
        {
            turn = Input.GetAxis("Horizontal");
        }

        BasicCarController.ChangeSpeed(forward);
        BasicCarController.Turn(turn);
    }
}
