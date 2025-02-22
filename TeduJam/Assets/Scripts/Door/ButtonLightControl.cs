using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonLightControl : MonoBehaviour
{
   
    public DoorController doorController;
    public string buttonType = "Button";

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag(buttonType))
        {
            
            ButtonResponse(); // Işık değdiğinde gerçekleşen olaylar
        }
    }
    public void ButtonAccess(bool access)
    {
        if(access){
            ButtonResponse();
        }
        else{

        }
    }
    private void AntiButton(){
        if (gameObject.CompareTag("RedButton"))
        {
            doorController.OpenDoor(); 
        }
        else if(gameObject.CompareTag("BlueButton"))
        {
            doorController.CloseDoor();
        }
    }
    private void ButtonResponse() //Buton rengine göre kapının açıldığı durumlar
    {
         if (gameObject.CompareTag("RedButton") && Input.GetKey(KeyCode.E))
        {
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
