using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLightControl : MonoBehaviour
{ 
    private bool isNearFlashLight = false;
    private int flashLİghtCount=0;
    private Collider2D flashLİghtCollider;
    public GameObject flashlightPrefab; // bırakacağımız fenerin prefabı
    public UIText uiText;
    
    void Update()
    {
        if(isNearFlashLight==true && Input.GetKeyDown(KeyCode.E))
        {
            PickUp();
        }

        if(Input.GetKeyDown(KeyCode.Q) && flashLİghtCount>0 )
        {
            Drop();
        }
    }

    private void OnTriggerEnter2D(Collider2D other) //Fenere yakınlaşınca aktifleşecek
    {
        if (other.CompareTag("flashlight"))
        {
            isNearFlashLight = true;  
            flashLİghtCollider=other;
        }
    }
    private void OnTriggerExit2D(Collider2D other) //Feneri bırakıp uzaklaşırken aktifleşecek
    {
        if(other.CompareTag("flashlight"))
        {
            isNearFlashLight= false;
            flashLİghtCollider=null;
        }
    }

    private void PickUp()
    {
       if(isNearFlashLight==true)
       {
          Destroy(flashLİghtCollider.gameObject);
          flashLİghtCount++;
          isNearFlashLight=false;
          flashLİghtCollider=null; // Fener sıfırlandı
          uiText.UpdateUIText(flashLİghtCount);

       }

    }

    private void Drop()
    {
        if(flashLİghtCount>0)
        {
            Instantiate(flashlightPrefab, transform.position, Quaternion.identity); //Oyuncunun durduğu yere feneri bırak
            flashLİghtCount--;
            uiText.UpdateUIText(flashLİghtCount);
        }
    }

}


