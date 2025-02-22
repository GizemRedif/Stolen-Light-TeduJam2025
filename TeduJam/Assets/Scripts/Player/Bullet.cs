using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Bullet : MonoBehaviour
{
    Rigidbody2D rb ;
    [SerializeField] float damage;
    public float speed;
    public float endTime;
    private GameObject target ;
    private Character targetpos;
    private Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
        target = GameObject.FindWithTag("Player");
        if(target != null){
            targetpos = target.GetComponent<Character>();
        }
        rb = GetComponent<Rigidbody2D>();
        if(targetpos.getXAxis() == -1){
            rb.transform.localScale = new Vector3(-1, 1, 1);
        }
        rb.velocity = new Vector2(targetpos.getXAxis(),0).normalized * speed;
        Destroy(gameObject,endTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Wall")){
            rb.velocity = Vector2.zero;
            Health health1 = collision.GetComponent<Health>();
            if(health1 != null){
                health1.takeDamage(damage);
            }
            anim.SetTrigger("Crash");
        }
        if(collision.CompareTag("Enemy")){
            rb.velocity = Vector2.zero;
            Health health = collision.GetComponent<Health>();
            //Minotour minotour = collision.GetComponent<Minotour>();
            /**if(minotour != null){
                rb.linearVelocity=Vector2.zero;
                minotour.takeDamage(damage);
                anim.SetTrigger("Crash");
            }**/
            if(health != null){
                rb.velocity=Vector2.zero;
                health.takeDamage(damage);
                anim.SetTrigger("Crash");
            }
        }

    }
    public void destroybullet(){
        Destroy(gameObject);
    }
}
