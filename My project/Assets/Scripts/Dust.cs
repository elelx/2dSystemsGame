using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dust : MonoBehaviour
{

    public float DustTimer = 3f;

    bool ifBroomTouch = false;
    bool TimerStart = false;

    private float timer = 0f;

    private void OnEnable()
    {
        ifBroomTouch = false;
        timer = DustTimer;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!ifBroomTouch)
        {
            return;
        }

        timer -= Time.deltaTime;

        Debug.Log( " timer: " + timer);

        if (timer <= 0f)
        {
            TimerEnds();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Broom") && !ifBroomTouch)
        {
            ifBroomTouch = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Broom"))
        {
            ifBroomTouch = false;
        }
    }
    void TimerEnds()
    {
        Debug.Log(" dust cleaned!");
        gameObject.SetActive(false);
    }
}
