using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSpawn : MonoBehaviour
{
    public GameObject magic;

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("z"))
        {

            GameObject magicProjectile = Instantiate(magic, transform.position + (transform.right * 2),
                Quaternion.identity);
            Rigidbody magicRB = magicProjectile.GetComponent<Rigidbody>();
            magicRB.AddRelativeForce(Vector3.forward*speed);
            Destroy(magicRB,3f);
        }
    }
}

