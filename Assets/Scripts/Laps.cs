using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Laps : MonoBehaviour
{

    [Header("Ai exclusive")]
    BasicCarController basiccar;
    public void Start()
    {
        
    }
    public void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            print("Finish");
        }
    }
}
