using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seagullNoise : MonoBehaviour
{
    public AudioClip seagullSFX;
    public GameObject ui;
    void Start()
    {
        HideUI();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Seagull");
            gameObject.GetComponent<AudioSource>().PlayOneShot(seagullSFX);
            ShowUI();
        }
    }
    public void HideUI()
    {
        ui.SetActive(false);
    }

    public void ShowUI()
    {
       ui.SetActive(true);
    }

    public void Close(){
        HideUI();
    }
}


