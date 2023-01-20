using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.UIElements;
using System.Threading;

public class Timer : MonoBehaviour
{
    float timertime = 0;
    bool timeRun = true;
    public TMP_Text timertext;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (timertime >= 0)
        {
            timertime += Time.deltaTime;
        }
        Displaytime(timertime);

    }

    void Displaytime(float timercurrent)
    {
        timercurrent += 1;
        float minutes = Mathf.FloorToInt(timercurrent/ 60);
        float seconds = Mathf.FloorToInt(timercurrent % 60);
        float milliseconds = (timercurrent% 1) * 1000;
        timertext.text = string.Format("{0:00}:{1:00}:{2:000}", minutes, seconds, milliseconds);   
    }
}
