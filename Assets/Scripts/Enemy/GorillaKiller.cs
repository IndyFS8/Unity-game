using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GorillaKiller : MonoBehaviour
{
    public GameObject gorilla;
    void OnTriggerEnter(Collider col){
        if (col.gameObject.CompareTag("Damage"))
        {
            gorilla.transform.rotation = Quaternion.Euler(0,90,0);
        }
        
    }

}