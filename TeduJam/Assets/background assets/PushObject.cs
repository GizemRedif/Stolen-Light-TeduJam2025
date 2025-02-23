using UnityEngine;

public class PushObject : MonoBehaviour
{

    //KARAKTERE EKLENECEK
    
    public float pushForce = 1f; // İtme kuvveti

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Rigidbody rb = hit.collider.attachedRigidbody;

        // Eğer objenin Rigidbody bileşeni yoksa veya kinematic ise, işlemi yapma
        if (rb == null || rb.isKinematic) return;

        // İtme yönünü hesapla (karakterin hareket yönü)
        Vector3 pushDir = hit.moveDirection;

        // Objeye kuvvet uygula (hem yatay hem dikey)
        rb.velocity = pushDir * pushForce;
    }
}
