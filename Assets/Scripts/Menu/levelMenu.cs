using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelMenu : MonoBehaviour
{
   public int CurrentScene;
    public void Start()
    {
        CurrentScene = SceneManager.GetActiveScene().buildIndex; //Pakt het nummertje van de buildindex van de scene waar je op dat moment bent ingeladen.
    }   
    public void quitGame()
    {
        Application.Quit();
        Debug.Log("Works");
        
    }
    public void Levels()
    {
        SceneManager.LoadScene("Levels", LoadSceneMode.Single); // LoadSceneMode.Single zorgt ervoor dat alleen 1 scene inlaad en dat alle andere scenes sluit.
    }

    public void Options()
    {
        SceneManager.LoadScene("Options", LoadSceneMode.Single);
    }
    // hier worden de level knoppen toegewezen 
    public void Level1()
    {
        SceneManager.LoadScene("Level1", LoadSceneMode.Single);
    }
    public void Level2()
    {
        SceneManager.LoadScene("Level2", LoadSceneMode.Single);
    }

    public void Koop()
    {
        SceneManager.LoadScene("Koop", LoadSceneMode.Single);
    }
     
  
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }
    public void AiWin()
    {
        SceneManager.LoadScene("WinscreenAi", LoadSceneMode.Single);
    }
    public void PlayerWin()
    {
        SceneManager.LoadScene("Winscreenplayer", LoadSceneMode.Single);
    }
    public void Restart()
    {
        if (CurrentScene == 3) // Als CurrentScene zijn buildindex gelijk is aan nummertje 3 (Level1)
        {
            SceneManager.LoadScene("Level1", LoadSceneMode.Single); 
        }
        else
        {
            SceneManager.LoadScene("Level2", LoadSceneMode.Single);
        }
    }
}
