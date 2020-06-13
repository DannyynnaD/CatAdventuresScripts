using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    public AudioSource Running;
    public AudioSource Jumping;

    public void PlayRunning()
    {
        Running.Play();
    }
    public void PlayJumping()
    {
        Jumping.Play();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.D))
        {
            Running.Play();
        }
            else if(Input.GetKeyDown(KeyCode.A))
            {
                Running.Play();
            }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Jumping.Play();
        }
    }
}

