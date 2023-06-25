using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    [SerializeField]
    private GameObject particle;

    // Start is called before the first frame update
    void Start()
    {
        particle.SetActive(false);
         
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow))
        {
            particle.SetActive(true);
        }
        else
        {
            particle.SetActive(false);
        }
         
         
    }

    }

