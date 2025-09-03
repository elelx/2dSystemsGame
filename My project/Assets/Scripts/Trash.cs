using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour
{

    bool putAway = false;
    bool dust = true;


    bool UnTouchedTrash = false;

    public GameObject Dust;

    //public float DustTimer = 2f;
   // public float HowLongTrashisOnFloorTime;



    // Start is called before the first frame update
    void Start()
    {
        
    }



    // Update is called once per frame
    void Update()
    {
        GameObject[] trash = GameObject.FindGameObjectsWithTag("Trash");

        if (trash.Length > 0)
        {
            UnTouchedTrash = true;

            Instantiate(Dust, transform.position, transform.rotation);

        }

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("TrashCan"))
        {
            Debug.Log("TrashAway");

            gameObject.SetActive(false);

            dust = false;
        }


    }
}
