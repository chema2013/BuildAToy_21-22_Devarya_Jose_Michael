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

    public bool reset = false;


    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;

        bestTime.text = PlayerPrefs.GetString("BestTime", "0").ToString();
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

    }

    public void Finish()
    {
        finished = true;
        timerText.color = Color.yellow;

        
            PlayerPrefs.SetString("BestTime",jj);
            bestTime.text = jj.ToString();

            
        
    }
}
