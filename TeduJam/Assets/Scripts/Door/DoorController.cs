using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public Animator door;

    public void OpenDoor()
    {
        door.SetTrigger("Open");
    }

    public void CloseDoor()
    {
        door.SetTrigger("Close");
    }
}
