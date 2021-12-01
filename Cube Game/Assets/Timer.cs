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

    float kk;


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

        int minutes = ((int) t / 60);

        float seconds = (t % 60);
        
        timerText.text = (minutes + ":" + seconds).ToString();

        jj = timerText.text;

        kk = seconds;
    }

    public void Finish()
    {
        finished = true;
        timerText.color = Color.yellow;

        if(kk > PlayerPrefs.GetFloat("BestTime", 0))
        {
            PlayerPrefs.SetString("BestTime", jj);
            bestTime.text = jj.ToString();
            PlayerPrefs.SetFloat("BestTime", kk);
        }
        
    }
}
