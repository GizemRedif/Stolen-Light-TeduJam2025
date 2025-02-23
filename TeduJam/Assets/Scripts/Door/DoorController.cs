using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    Animator door;
    private bool situation;
    void Start()
    {
        door = GetComponent<Animator>();
    }
    void Update()
    {
        OpenDoor();
        CloseDoor();
    }
    public void OpenDoor()
    {
        if(situation){
            Debug.Log("Kapı açıldı");
            door.SetTrigger("Open");
        }
        
    }

    public void CloseDoor()
    {
        if(situation){
            door.SetTrigger("Close");
        }
    }
    public void DoorPos(bool situation){
        this.situation = situation;
    }
}
