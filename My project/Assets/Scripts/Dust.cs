using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dust : MonoBehaviour
{

    public float DustTimer = 3f;

    bool ifBroomTouch = false;
    bool TimerStart = false;

    private float CleanDusttimer = 0f;

    bool UntocuhedTrash = false;

    public GameObject dust;


    private void OnEnable()
    {
        ifBroomTouch = false;
        CleanDusttimer = DustTimer;
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

        CleanDusttimer -= Time.deltaTime;

        Debug.Log( " timer: " + CleanDusttimer);

        if (CleanDusttimer <= 0f)
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
