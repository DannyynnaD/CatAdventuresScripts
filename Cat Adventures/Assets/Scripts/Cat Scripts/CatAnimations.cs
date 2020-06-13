using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatAnimations : MonoBehaviour
{
    private Animator animation;
    void Start()
    {
        animation = GetComponent<Animator>();
    }

    
    void Update()
    {
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
             animation.SetBool("Running", true);
        }
            else
            {
                animation.SetBool("Running", false);
            }

        if(Input.GetKey(KeyCode.Space))
        {
            animation.SetTrigger("Jump");
        }

    }
}
