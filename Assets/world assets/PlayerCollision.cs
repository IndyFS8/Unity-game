using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public GameObject kangaroo;
    void OnTriggerEnter(Collider col){
        if (col.gameObject.name == "Kangaroo_01")
        {
            kangaroo.transform.position = new Vector3(167.5f, 114.5f, -131f); 
        }
        
    }

}
