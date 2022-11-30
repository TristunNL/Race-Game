using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiController : MonoBehaviour
{
    [Header("Input Variables")]
    public float forwards = 1;
    CarControllerScript carControllerScript;

    // Start is called before the first frame update
    void Awake ()
    {
        carControllerScript = GetComponent<CarControllerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        carControllerScript.changeSpeed(forwards);
    }
}
