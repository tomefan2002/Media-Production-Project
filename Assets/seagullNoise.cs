using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seagullNoise : MonoBehaviour
{
    public AudioClip seagullSFX; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player") {
            Debug.Log("Seagull");
            gameObject.GetComponent<AudioSource>().PlayOneShot(seagullSFX);
        }
    }
}
