using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadGorilla : MonoBehaviour
{
    public GameObject Gorilla;
    public float health;


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
    }

    public void Death()
    {
        Destroy(Gorilla);
        
    }
}
