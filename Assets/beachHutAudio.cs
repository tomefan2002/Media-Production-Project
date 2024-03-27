using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beachHutAudio : MonoBehaviour
{
    public AudioClip seagull;
    void Start()
    {
        Debug.Log("hello");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other){

        Debug.Log("hit");
        if(other.tag == "Player"){
             gameObject.getComponent<AudioSource>().PlayOneShot(seagull);

         }
    }
}
