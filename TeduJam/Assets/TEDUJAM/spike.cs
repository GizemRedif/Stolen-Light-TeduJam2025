using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class spike : MonoBehaviour
{
    public float damage = 1;
    private bool isPlayer;
    private Character script;
    private float timer;
    private float timer2;
    private bool damaged  = false;
    private Collider2D col;
    private bool noLight = false;

    void Start()
    {
        col = GetComponent<Collider2D>();   
    }

    // Update is called once per frame
    void Update()
    {
        Spike(noLight);
        if (noLight == false && col.enabled == true)
        {
            Debug.Log("ýþýk yokken diken açýk");
            timer2 += Time.deltaTime;
            if (isPlayer && script != null && damaged == false)
            {
                damaged = true;
                script.TakeDamage(damage);
                timer2 = 0;
            }
            if (damaged == true && timer2 >= 1f)
            {
                damaged = false;
                
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            isPlayer = true;
            script = collider.GetComponent<Character>();
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isPlayer = false;
            script = null;
        }
    }
    public void Spike(bool light)
    {
        if (light)
        {
            Debug.Log("SA sa sa");
            timer += Time.deltaTime;
            
            if (timer <= 0.5f)
            {
                GetComponent<Collider2D>().enabled = false;
                damaged = false;
                

            }
            else if (0.5f<timer && timer < 1.5f)
            {
                Debug.Log(GetComponent<Collider2D>().enabled);
                GetComponent<Collider2D>().enabled = true;
                if (isPlayer && script != null && damaged==false)
                {
                    damaged = true;
                    script.TakeDamage(damage);
                }
            }
            else if(timer >= 1.5f)
            {
                timer = 0;
            }
        }
        else
        {
            noLight = false;
        }
        
    }
    public void setSpike(bool noLight){this.noLight = noLight;}
}