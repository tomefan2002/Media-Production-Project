using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class llyDialogue : MonoBehaviour
{
    public GameObject can4;
    public GameObject dia1;
    public GameObject dia2;
    public GameObject talkButton;
    public GameObject nextButton;
    public GameObject closeButton;

    // Start is called before the first frame update
    void Start()
    {
        can4.SetActive(false);
        dia1.SetActive(false);
        dia2.SetActive(false);
        talkButton.SetActive(false);
        nextButton.SetActive(false);
        closeButton.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            can4.SetActive(true);
            talkButton.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

    public void talkFunc()
    {
        talkButton.SetActive(false);
        dia1.SetActive(true);
        nextButton.SetActive(true);
        closeButton.SetActive(true);

    }

    public void nextFunc()
    {
        dia1.SetActive(false);
        dia2.SetActive(true);
        nextButton.SetActive(false);
    }

    public void closeFunc()
    {
        can4.SetActive(false);
        dia1.SetActive(false);
        dia2.SetActive(false);
        talkButton.SetActive(false);
        nextButton.SetActive(false);
        closeButton.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

}
