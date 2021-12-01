using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public Text timerText;

    private float startTime;

    private bool finished = false;

    public Text bestTime;

    string jj;


    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;

        bestTime.text = PlayerPrefs.GetString("BestTime", "0");
    }

    // Update is called once per frame
    void Update()
    {
        if(finished)
        return;

        float t = Time.time - startTime;

        string minutes = ((int) t / 60).ToString();

        string seconds = (t % 60).ToString("f2");
        
        timerText.text = minutes + ":" + seconds;

        jj = timerText.text;
    }

    public void Finish()
    {
        finished = true;
        timerText.color = Color.yellow;

        PlayerPrefs.SetString("BestTime", jj);


    }
}
