using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seagullNoise : MonoBehaviour
{
    public AudioClip seagullSFX;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Seagull");
            gameObject.GetComponent<AudioSource>().PlayOneShot(seagullSFX);
        }
    }
}


