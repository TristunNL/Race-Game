using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UsernameGen : MonoBehaviour
{
    public TMP_Text AIUser;
    private string[] AINames =
    {
        "TristanBot",
        "Matthijs",
        "Sophie",
        "GeenBot",
        "Koop",
        "Bertha"
    };
    
    List<string> AIList = new List<string>();
    void Start()
    {
        AIList.AddRange(AINames);
        int rnd = Random.Range(0, AIList.Count);
        AIUser.text = AIList[rnd];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
