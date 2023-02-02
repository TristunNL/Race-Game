using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Koopdeur : MonoBehaviour
{ 
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Koopdeur") && this.CompareTag("Player"))
        {
            SceneManager.LoadScene(5);
            
        }
        if (other.CompareTag("koopDeurBinnen"))
        {
            SceneManager.LoadScene(3);
        }
    }
}
