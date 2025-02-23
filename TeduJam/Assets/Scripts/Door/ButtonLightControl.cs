using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonLightControl : MonoBehaviour
{
   
    public DoorController doorController;
    public string buttonType = "Button";
    private int buttoncounter = 0;
    private bool islight = false;

    public void ButtonAccess(bool islight)
    {
        this.islight = islight;
    }
    void Update()
    {
        if(islight){
            Debug.Log("ışık var");
            Debug.Log("Tuşa basıldı");
            ButtonResponse();
        }
        else{
            Debug.Log("ışık yyok");
            if(gameObject.CompareTag("BlueButton"))
            {
                
                doorController.isopenDoor(true);
            }
        }
    }
    private void ButtonResponse() //Buton rengine göre kapının açıldığı durumlar
    {
        
         if (gameObject.CompareTag("RedButton") )
        {
            if(Input.GetKeyDown(KeyCode.E)){
                doorController.isopenDoor(true); 
                buttoncounter ++;
                Debug.Log("Counter:"+buttoncounter);
            }
            if(buttoncounter == 2 ){
                buttoncounter = 0;
                doorController.isopenDoor(false);
                Debug.Log("Counter:"+buttoncounter);
            }
            Debug.Log("Tuşa basıldı");
        }
        else if(gameObject.CompareTag("BlueButton"))
        {
            
            doorController.isopenDoor(false);
        }
        else if(gameObject.CompareTag("GreenButton"))
        {
            doorController.isopenDoor(true);
            StartCoroutine(CloseDoorAfterTime(5f));
        }

    }
     private IEnumerator CloseDoorAfterTime(float time) //Süreyle kapının açık kalması
    {
        yield return new WaitForSeconds(time);
        doorController.isopenDoor(false);
    }
}
