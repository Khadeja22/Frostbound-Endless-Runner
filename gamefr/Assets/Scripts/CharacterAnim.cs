using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnim : MonoBehaviour
{
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    /*void FixedUpdate(){
        Vector3 addPos = new Vector3(0, Mathf.Clamp(transform.position.y - 0.0002f, 0, int.MaxValue), 0);
        transform.position += addPos;
    }*/
   
    void Update(){
        //running to the right
        if(Input.GetKey(KeyCode.RightArrow))
        {
            anim.SetBool("isRunning", true);
        }
        else
        {
            anim.SetBool("isRunning", false);
        }

        //jumping 
        if(Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("Jump");
        }
    }



    
}
