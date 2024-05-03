using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishObj : MonoBehaviour
{

    public GameObject fish;
    public GameObject fishOb;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
           fish.SetActive(false);
           fishOb.SetActive(false);
    
        }
    }
}
