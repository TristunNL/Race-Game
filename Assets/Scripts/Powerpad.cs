using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Powerpad : MonoBehaviour
{
    private Canvas CanvasObject; // Assign in inspector
    [SerializeField]
    Text Menu; // hier wordt text aan geroepen 
    void Awake()
    {

    }

    void Start()
    {
        CanvasObject = GetComponent<Canvas>();
        Menu.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0;
            Menu.enabled = true;
            CanvasObject.enabled = !CanvasObject.enabled;

        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Time.timeScale = 1;
            Menu.enabled = false;
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        // hier kan je een finish lijn mee maken 
    }
}
