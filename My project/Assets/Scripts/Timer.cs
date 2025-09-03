using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float countDownTimer = 120f;
    public TextMeshProUGUI timerText;



    private bool winGame = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        countDownTimer -= Time.deltaTime;

        if (countDownTimer <= 0f)
        {
            countDownTimer = 0;
            timerEnded();


        }
   
        timerText.text = Mathf.CeilToInt(countDownTimer).ToString();
    }

    void timerEnded()
    {

        GameObject[] dust = GameObject.FindGameObjectsWithTag("Dust");
        GameObject[] trash = GameObject.FindGameObjectsWithTag("Trash");
        GameObject[] toys = GameObject.FindGameObjectsWithTag("Toys");

        if (dust.Length == 0 && trash.Length == 0 && toys.Length == 0)
        {
            winGame = true;

            Debug.Log("winnter!");

        }

        else if (dust.Length > 0 ||  trash.Length > 0 || toys.Length > 0)
        {
            winGame = false;

            Debug.Log("u lose");
        }

    }

}
