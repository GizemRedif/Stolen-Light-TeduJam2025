using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReflectLight : MonoBehaviour
{
    public LayerMask layerMask; //Reflektör objelerin layer'ý
    public GameObject[] lightSource; // Reflektör objelerin ýþýk kaynaðý
    public GameObject[] reflectors; //Reflektör objeler
    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < reflectors.Length; i++) // Reflektör objelerin sayýsý kadar döngü
        {
            GameObject reflector = reflectors[i]; // Reflektör objesini al
            Vector2 lightToObj = (reflector.transform.position - transform.position).normalized; // Iþýk kaynaðý ile reflektör arasýndaki vektör
            float angle = Vector2.Angle(transform.up, lightToObj); // Iþýk kaynaðý ile reflektör arasýndaki açý

            if (angle < GetComponent<UnityEngine.Rendering.Universal.Light2D>().pointLightInnerAngle / 2f) // Iþýk kaynaðýnýn açýsýna göre reflektör objesini aktif et
            {
                lightSource[i].gameObject.SetActive(true); // Iþýk kaynaðýný aktif et
                RaycastHit2D hit2D = Physics2D.Raycast(transform.position, (reflector.transform.position - transform.position).normalized, 20f, layerMask); // Iþýk kaynaðý ile reflektör arasýnda bir ýþýn çiz

                if (hit2D.collider != null)// Eðer ýþýn bir objeye çarparsa
                {
                    Debug.DrawLine(transform.position, hit2D.point, Color.yellow, 0.1f);// Iþýk kaynaðý ile çarpýþan obje arasýnda bir çizgi çiz
                    Vector2 incomingDirection = (reflector.transform.position - transform.position).normalized; // Iþýk kaynaðý ile çarpýþan obje arasýndaki vektör
                    Vector2 reflectedDirection = Vector2.Reflect(incomingDirection, hit2D.normal); // Iþýk kaynaðýnýn yansýyan yönü
                    Debug.DrawRay(hit2D.point, reflectedDirection * 5f, Color.green, 1f); // Yansýyan yönü çiz

                    // Iþýk kaynaðýný yansýyan yönüne döndür
                    lightSource[i].transform.up = reflectedDirection;

                }
            }
            else
            {
                lightSource[i].gameObject.SetActive(false);
            }
            Debug.Log(angle);
        }




    }
}
