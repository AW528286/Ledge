using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public TMP_Text timerText;
    private float startTime;
    private bool finished = false;
    private bool Started = false;

    // Start is called before the first frame update

    void start()
    {
      

        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (finished)
            return;

        
        
            float t = Time.time - startTime;

            string minutes = ((int)t / 60).ToString();
            string seconds = (t % 60).ToString("f2");

            timerText.text = minutes + ":" + seconds;
        

      
    }

    public void Finish()
    {
        finished = true;
        timerText.color = Color.yellow;
    }


}
