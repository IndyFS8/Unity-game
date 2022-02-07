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
    
    public GameOverScreen GameOverScreen;
    public int GorillasKilled;
    
    public void GameOver()
    {
        GameOverScreen.Setup(GorillasKilled);
    }
    
    


    void start()
    {
        
    }
    

    private void OnTriggerEnter(Collider col)
    {
        Random rnd = new Random();

        if (col.gameObject.CompareTag("Weapon"))
        {
            health -= 1;
            // add taking dmg animation
            
            
            if (health < 1)
            {
                for (int i = 0; i < 6; i++)
                {
                    var x = rnd.Next(-130, 100);
                    Debug.Log(rnd.Next(-130,200));
                    var z = rnd.Next(-200, 200);
                    Spawn(x, z);
                    Death();
                    GorillasKilled++;
                }
            }

        }  
        if (col.gameObject.CompareTag("Player"))
        {
            // add taking dmg animatio
            KangyDeath();
            

        } 
        
    }

    public void Spawn(int x, int z)
    {
        var position = new Vector3(x, 80, z);
        var raycastResult = Physics.Raycast(position, Vector3.down, out var hit);
        if (!raycastResult)
        {
            throw new Exception($"Could not find a spawn for {this}");
        }
        var newGowilla = Instantiate(Gorilla, hit.point + 2 *Vector3.up, Quaternion.identity);
        newGowilla.GetComponent<DeadGorilla>().health = 3;
        newGowilla.GetComponent<NavMeshAgent>().enabled = true;
        newGowilla.GetComponent<EnemyController>().enabled = true;

    }

    public void Death()
    {
        Destroy(Gorilla);
    }

    public void KangyDeath()
    {
        GameOver();
        Destroy(Kangaroo);
        
    }
}
