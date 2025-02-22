using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public Animator door;
    private bool situation;

    public void OpenDoor()
    {
        if(situation){
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
