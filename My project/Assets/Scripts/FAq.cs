using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FAq : MonoBehaviour
{
    [SerializeField] private GameObject FAQ; // assign your hidden UI here

    private bool isOpen = false;

    void Start()
    {
        FAQ.SetActive(false); // make sure it's hidden at start
    }

    public void OpenClose()
    {
        isOpen = !isOpen;
        FAQ.SetActive(isOpen);
    }

    void Update()
    {
        if (isOpen && Input.GetMouseButtonDown(0))
        {
          
                ClosePopup();
           
        }
    }

    public void ClosePopup()
    {
        isOpen = false;
        FAQ.SetActive(false);
    }

}
