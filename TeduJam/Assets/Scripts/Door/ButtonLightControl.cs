using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonLightControl : MonoBehaviour
{
   
    public DoorController doorController;
    public string buttonType = "Button";

    public void ButtonAccess(bool access)
    {
        Debug.Log("girdi");
        if(access){
            ButtonResponse();
        }
        else{

        }
    }
    private void ButtonResponse() //Buton rengine göre kapının açıldığı durumlar
    {
         if (gameObject.CompareTag("RedButton") && Input.GetKey(KeyCode.E))
        {
            Debug.Log("Tuşa basıldı");
            doorController.OpenDoor(); 
        }
        else if(gameObject.CompareTag("BlueButton"))
        {
            doorController.CloseDoor();
        }
        else if(gameObject.CompareTag("GreenButton"))
        {
            doorController.OpenDoor();
            StartCoroutine(CloseDoorAfterTime(5f));
        }

    }
     private IEnumerator CloseDoorAfterTime(float time) //Süreyle kapının açık kalması
    {
        yield return new WaitForSeconds(time);
        doorController.CloseDoor();
    }
}
