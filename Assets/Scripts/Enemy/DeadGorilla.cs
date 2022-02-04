using System;
using Random= System.Random;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.AI;

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
        Random rnd = new Random();
        var x = rnd.Next(-130, 100);
        var z = rnd.Next(-200, 200);
        if (col.gameObject.CompareTag("Weapon"))
        {
            health -= 1;
            // add taking dmg animation
            
            
            if (health < 1)
            {
                Death(x,z);
            }

        }  
        if (col.gameObject.CompareTag("Player"))
        {
            // add taking dmg animatio
            KangyDeath();

        } 
        
    }

    public void Death(int x, int z)
    {
        var position = new Vector3(x, 80, z);
        var raycastResult = Physics.Raycast(position, Vector3.down, out var hit);
        if (!raycastResult)
        {
            throw new Exception($"Could not find a spawn for {this}");
        }

        Destroy(Gorilla);
        var newGowilla = Instantiate(Gorilla, hit.point + 2 *Vector3.up, Quaternion.identity);
        newGowilla.GetComponent<NavMeshAgent>().enabled = true;
        newGowilla.GetComponent<EnemyController>().enabled = true;

    }

    public void KangyDeath()
    {
        Destroy(Kangaroo);
        
    }
}
