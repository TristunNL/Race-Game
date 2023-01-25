using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Win : MonoBehaviour
{ 
    // Zelf gemaakt 

    // reset checkpoint list 

    // Player variablelen
    public int checkpoints = 0;
    private int alleCheckpoints = 17;
    public int Lapcounter = 0;

    // ai variabelen 
    public int aicheckpoints = 0;
    private int aialleCheckpoints = 17;
    public int aiLapcounter = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    { 
         //maak in de scene dat je kan restarten of exit
        // maak een nieuwe scene met de winnaar 
        // hier worden de laps gemaakt voor de speler als de speler sneller is wint de speler


        if (Lapcounter == 1)
        {
            print("Ronde " + Lapcounter);  
            // hier wordt het canvas gemaakt voor de speler   
        }
        if (Lapcounter == 3)
        {
            print("You finished first");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +2);
        }
       // hier worden de laps gemaakt voor de ai als de ai sneller is wint de ai 
         //add nog een canvas met ai heeft gewonnen 

        if (aiLapcounter == 1)
        {
            // hier wordt het canvas gemaakt voor de ai 
        }
        print("Ronde " + aiLapcounter);
        if (aiLapcounter == 3)
        {
            print("Ai finished first");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        {
            if (other.CompareTag("Checkpoints") && this.CompareTag("Player"))
            {
                checkpoints++;
                if (checkpoints == alleCheckpoints)
                {
                    if (checkpoints == 17)
                    {
                        Lapcounter++;
                        if (Lapcounter > 0)
                        {
                            checkpoints = 0;
                        }
                    }
                }
            }
            if (other.CompareTag("Checkpoints") && this.CompareTag("Ai"))
            {
                aicheckpoints++;
                if (aicheckpoints == aialleCheckpoints)
                { 
                    if (aicheckpoints == 17)
                    {
                        aiLapcounter++;
                        if (aiLapcounter > 0)
                        {
                            aicheckpoints = 0;
                        }
                    }
                }
            }
        }
    }
}
