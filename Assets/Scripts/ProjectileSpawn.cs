using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSpawn : MonoBehaviour
{
    public GameObject magic;
    public GameObject kangaroo;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newRotation = new Vector3(kangaroo.transform.eulerAngles.x, kangaroo.transform.eulerAngles.y,
            kangaroo.transform.eulerAngles.z);
        if (Input.GetKeyDown("z"))
        {

            GameObject magicProjectile = Instantiate(magic, transform.position + (transform.right * 2),
                Quaternion.identity);
            magicProjectile.transform.eulerAngles = newRotation;
            Rigidbody magicRB = magicProjectile.GetComponent<Rigidbody>();
            magicRB.AddForce(magicRB.transform.forward * speed );
            Destroy(magicProjectile,3f);
        }
    }
}

