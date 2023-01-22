using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public static bool GameIsPaused = false; // hier wordt een bool aangemaakt die standaard false is
    public GameObject pausedMenuUI; // hier wordt een public GameObject gemaakt waar je de canvas in kan slepen 


    public void Start() // dit wordt 1 keer uit gevoert aan het begin 
    {
        Resume(); // hij voert hier resume uit zodat je de menu niet kan zien in het begin 
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) // hier wordt ervoor gezorgt dat je als je op de escape knop drukt het menu te voorschijn komt 
        {
            if (GameIsPaused)
            {
                Resume(); // hier wordt de functie Resume aangeroepen
            }else
            {
                Paused(); // hier wordt de functie Paused aangeroepen als Resume niet actief is 
            }

        }
    }

    public void Resume()
    {
        // hier wordt de tijd van pauze af gehaalt 
        pausedMenuUI.SetActive(false);
        Time.timeScale = 1; // hier wordt de tijd van stop afgehaad 
        GameIsPaused = false; // hier wordt de bool op false gezet terwijl hij al false is dus gebeurt er niks
    }
    public void Paused()
    {
        // hier wordt de tijd op pauze gezet 
        pausedMenuUI.SetActive(true); 
        Time.timeScale = 0; // hier wordt de game op pauze gezet 
        GameIsPaused = true; // hier wordt de bool op true gezet waardoor het wel op pauze gaat 
    }
    public void Exit()
    {
        // hier wordt de functie aan gemaakt zo dat je naar het level menu kan
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }
}
