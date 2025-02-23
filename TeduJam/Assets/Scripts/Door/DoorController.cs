using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    Animator anim;
    private bool situation = false;
    private bool ButtonSitu = false;
    private bool transformtime = false;
    private bool flag = true;
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        if(situation){
            Debug.Log("Kapı tespiti");
            if(ButtonSitu){
                anim.SetBool("isOpen",ButtonSitu);
                anim.SetBool("isReady",transformtime);
            }
            else{
                anim.SetBool("isOpen",ButtonSitu);
                anim.SetBool("isReady",transformtime);
            }
        }
    }
    public void isopenDoor(bool ButtonSitu)
    {
        this.ButtonSitu = ButtonSitu  ;
        transformtime = true;
    }

    public bool CloseDoor()
    {
        return false;
    }
    public void DoorPos(bool situation){
        this.situation = situation;
    }
}
