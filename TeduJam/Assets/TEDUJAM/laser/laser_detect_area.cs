using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser_detect_area : MonoBehaviour
{
    private bool isPlayer;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.CompareTag("Player"))
        {
            isPlayer = true;   
        }
        
    }
    void OnTriggerExit2D(Collider2D col)
    {

        if (col.CompareTag("Player"))
        {
            isPlayer = false;          
        }
        
    }
    public bool getIsPlayer()
    {
        return isPlayer;
    }
}
