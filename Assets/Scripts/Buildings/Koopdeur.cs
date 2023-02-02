using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Koopdeur : MonoBehaviour
{ 
    public void koopDeurBuiten()
    {
        SceneManager.LoadScene(5);
  
    }

    public void koopDeurBinnen()
    {
        SceneManager.LoadScene(4);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Koopdeur"))
        {
            koopDeurBuiten();
        }
        if (other.CompareTag("koopDeurBinnen"))
        {
            koopDeurBinnen();
        }
    }
}
