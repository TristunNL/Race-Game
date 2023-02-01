using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Koopdeur : MonoBehaviour
{ 
    public void koopDeurBuiten()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
  
    }

    public void koopDeurBinnen()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
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
