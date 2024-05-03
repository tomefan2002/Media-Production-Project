using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class houseUI : MonoBehaviour
{
    public GameObject ui;
    public GameObject beachHouse;
    public GameObject beachOb;
    public GameObject beachOb2;

    void Start()
    {
        HideUI();
        beachOb2.SetActive(false);
    }


    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            LearnMore();
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

    public void HideUI()
    {
        ui.SetActive(false);
        beachHouse.SetActive(false);

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void ShowUI()
    {
        ui.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void Close()
    {
        HideUI();
        beachOb.SetActive(false);
        beachOb2.SetActive(true);
    }

    public void LearnMore()
    {
        beachHouse.SetActive(true);
    }
}
