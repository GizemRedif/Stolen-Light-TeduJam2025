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
    private Vector2 lastMoveDir;
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

        if (moveX != 0) 
        {
            anim.SetBool("RightWalk", true);
            anim.SetBool("UpWalk", false);
            anim.SetBool("DownWalk", false);
            transform.localScale = new Vector3(moveX > 0 ? 1 : -1, 1, 1); // Sağ/sol dönüş
        }
        else if (moveY > 0) 
        {
            anim.SetBool("UpWalk", true);
            anim.SetBool("RightWalk", false);
            anim.SetBool("DownWalk", false);
        }
        else if (moveY < 0) 
        {
            anim.SetBool("DownWalk", true);
            anim.SetBool("RightWalk", false);
            anim.SetBool("UpWalk", false);
        }
        else 
        {
            anim.SetFloat("LastMoveX", lastMoveDir.x);
            anim.SetFloat("LastMoveY", lastMoveDir.y);
            anim.SetBool("RightWalk", false);
            anim.SetBool("UpWalk", false);
            anim.SetBool("DownWalk", false);
        }
    }
    private void  FixedUpdate() {
        rb.velocity = moveVelocity;
    }
}
