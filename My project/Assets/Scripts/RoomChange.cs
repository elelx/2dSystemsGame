using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RoomChange : MonoBehaviour
{

    [SerializeField] private string roomName;

    void Start()
    {
        
    }

    // Update is called once per frame
    public void ChangeRoom()
    {
        SceneManager.LoadScene(roomName);
    }
}
