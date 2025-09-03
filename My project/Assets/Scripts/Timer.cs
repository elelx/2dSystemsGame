using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float countDownTimer = 120f;
    public TextMeshProUGUI timerText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        countDownTimer -= Time.deltaTime;

        if(countDownTimer <= 0f)
        {
            timerEnded();
        }

        timerText.text = Mathf.CeilToInt(countDownTimer).ToString();
    }

    void timerEnded()
    {
        Debug.Log("times up!");
    }
}
