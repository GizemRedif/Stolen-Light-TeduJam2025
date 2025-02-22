using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float speed = 0f ; 
    private Vector2 moveVelocity;
    private float move1;
    private float move2;
    private Rigidbody2D rb;
    private Vector2 moveDirection;
    private Animator anim;
    private float X_pos = 1;
    bool isrun = false;
    bool Alive = true;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();       
    }

    
    void Update()
    {
        Move();
    }
    public void Move(){

        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        // Hareket yönünü belirle
        Vector2 moveDirection = new Vector2(moveX, moveY).normalized;
        moveVelocity = moveDirection * speed;

        // **Animasyonları Kontrol Et**
        if (moveX != 0) 
        {
            anim.SetBool("RightWalk", true);
            transform.localScale = new Vector3(moveX > 0 ? 1 : -1, 1, 1); // Sağ/sol dönüş
        }
        else 
        {
            anim.SetBool("RightWalk", false);
        }

        if (moveY > 0) 
        {
            anim.SetBool("UpWalk", true);
        }
        else 
        {
            anim.SetBool("UpWalk", false);
        }

        if (moveY < 0) 
        {
            anim.SetBool("DownWalk", true);
        }
        else 
        {
            anim.SetBool("DownWalk", false);
        }
    }
    private void  FixedUpdate() {
        rb.velocity = moveVelocity;
    }
}
