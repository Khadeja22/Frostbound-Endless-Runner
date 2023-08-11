using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootprintParticleController : MonoBehaviour
{
    public ParticleSystem Footprints; // Assign the Particle System GameObject in the Inspector

    private void Update()
    {
        bool isMoving = Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow);

        if (isMoving)
        {
            if (!Footprints.isPlaying)
            {
                Footprints.Play(); // Start emitting particles
            }
        }
        else
        {
            if (Footprints.isPlaying)
            {
                Footprints.Pause(); // Pause emitting particles
            }
        }
    }
}