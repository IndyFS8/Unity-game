using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class DeadGorilla : MonoBehaviour
{
    public GameObject Gorilla;
    public float health;
    public GameObject Kangaroo;


    void start()
    {
        
    }
    

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Weapon"))
        {
            health -= 1;
            // add taking dmg animation
            
            
            if (health < 1)
            {
                Death();
            }

        }  
        if (col.gameObject.CompareTag("Player"))
        {
            // add taking dmg animatio
            KangyDeath();

        } 
        
    }

    public void Death()
    {
        Destroy(Gorilla);
        
    }

    public void KangyDeath()
    {
        Destroy(Kangaroo);
    }
}
