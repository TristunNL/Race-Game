using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Koopdeur : MonoBehaviour
{ 
    public void Levels()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log("Works");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Koopdeur"))
        {
            Levels();
        }
    }
}
