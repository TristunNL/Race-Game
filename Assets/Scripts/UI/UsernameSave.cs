using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UsernameSave : MonoBehaviour
{
    public string playerKey = "playerKey"; // "playerKey" is default ofzo
    public string playerName;
    public Text inputField;

    void Start()
    {
        if (PlayerPrefs.HasKey(playerKey)) // als hij een Key heeft (maakt hij aan in  public void SetString wanneer je op save klikt)
        {
            playerName = PlayerPrefs.GetString(playerKey); //playerName heeft hetzelfde value als playerKey
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetString()
    {
        PlayerPrefs.SetString(playerKey,inputField.text); // Zorgt ervoor dat playerKey van inputfield.text word gestored
        playerName = PlayerPrefs.GetString(playerKey);
    }
}
