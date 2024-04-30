using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fishCollision : MonoBehaviour
{       
        private void OnTriggerEnter(Collider other){
            Debug.Log("fish");
            gameObject.SetActive(false);
        }


}


  

