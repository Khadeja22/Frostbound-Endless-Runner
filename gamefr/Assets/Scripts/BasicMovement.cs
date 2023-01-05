using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 horizontal = new Vector3(Input.GetAxis("Horizontal"), -0.25f, 0.0f);        
    }

    // Update is called once per frame
    void Update()
    {   //if you want to get the player to move to the left (back) then take out the if/else container and delete everything under else :-)
        if(Input.GetKey(KeyCode.RightArrow))
        {
        Vector3 horizontal = new Vector3(Input.GetAxis("Horizontal"), -0.25f, 0.0f);
        transform.position = transform.position + horizontal * Time.deltaTime;
        }
        else 
        {
            transform.position = transform.position;
        }
    }
}
