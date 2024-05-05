using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishObj : MonoBehaviour
{

    public GameObject fish;
    public GameObject fishOb;
    public GameObject llyOb;
    public GameObject learnMoreFish;
    public GameObject learnMoButton;
    public GameObject infoScreen;
    // Start is called before the first frame update
    void Start()
    {
        llyOb.SetActive(false);
        learnMoreFish.SetActive(false);
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
            llyOb.SetActive(true);
            learnMoreFish.SetActive(true);
            infoScreen.SetActive(false);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;


        }
    }

    public void learnMoreButton()
    {
        learnMoButton.SetActive(false);
        infoScreen.SetActive(true);
    }

    public void closeButton()
    {
        learnMoreFish.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
