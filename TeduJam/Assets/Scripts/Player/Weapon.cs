using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Weapon : MonoBehaviour
{
    [SerializeField] float fireRate = 0.5f;
    [SerializeField]Transform firePoint;
    [SerializeField] GameObject bullet;
    private Animator anim1;
    private float nextFireTime = 0f;

    private void Start() {
        
        anim1 = GetComponent<Animator>();
    }
    void Update()
    {
        
        if(Input.GetMouseButtonDown(0) && Time.time >= nextFireTime ){
            anim1.SetTrigger("Attack");
            nextFireTime = Time.time + fireRate;
        }
    }
    public void Shoot(){
        Instantiate(bullet,firePoint.position,firePoint.rotation);
    }
}
