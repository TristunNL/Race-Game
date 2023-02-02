using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UsernameText : MonoBehaviour
{
    public TMP_Text userText;
    public string playerKey = "playerKey";
    void Start()
    {
        userText.text = PlayerPrefs.GetString(playerKey);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
