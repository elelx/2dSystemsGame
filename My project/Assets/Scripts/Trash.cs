using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour
{

    bool putAway = false;
    bool dust = true;


    bool UnTouchedTrash = false;

    public GameObject Dust;

    public float DustSpawnTime = 2f;
    public float SpawnTimer = 0f;



    

    private void Start()
    {
 
    }

    void Update()
    {
        DustSpawnTime -= Time.deltaTime;

        if(dust && DustSpawnTime <= 0f)
        {
            GameObject[] trash = GameObject.FindGameObjectsWithTag("Trash");

            if (trash.Length > 0)
            {
                UnTouchedTrash = true;

                Instantiate(Dust, transform.position, transform.rotation);

                SpawnTimer = DustSpawnTime;
            }
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
