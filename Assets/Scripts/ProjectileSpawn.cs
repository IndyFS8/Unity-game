using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSpawn : MonoBehaviour
{
    public GameObject magic;
    public GameObject magic2;
    public GameObject kangaroo;

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hi");
        Cursor.visible = false;
        Physics.IgnoreCollision(magic2.GetComponent<Collider>(), kangaroo.GetComponent<Collider>());
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newRotation = new Vector3(0, kangaroo.transform.eulerAngles.y, 0);
        Vector3 currentRotation = new Vector3(0, kangaroo.transform.eulerAngles.y, 0);
        if (Input.GetKeyDown("q"))
        {

            GameObject magicProjectile = Instantiate(magic, transform.position + (transform.right),
                Quaternion.identity);
            magicProjectile.transform.eulerAngles = newRotation;
            Rigidbody magicRB = magicProjectile.GetComponent<Rigidbody>();
            magicRB.AddForce(magicRB.transform.forward * speed);
            Destroy(magicProjectile, 3f);
        }

        if (Input.GetKeyDown("e"))
        {
            for (int i = 0; i < 6; i++)
            {
                if (i != 3)
                {

                    if (kangaroo.transform.eulerAngles.y + i * 60 <= 360)
                    {
                        currentRotation.y = kangaroo.transform.eulerAngles.y + i * 60;
                    }
                    else
                    {
                        currentRotation.y = kangaroo.transform.eulerAngles.y + i * 60 - 360;
                    }

                    GameObject magicProjectile = Instantiate(magic2, transform.position,
                        Quaternion.identity);
                    currentRotation.x = 0;
                    currentRotation.z = 0;
                    magicProjectile.transform.eulerAngles = currentRotation;
                    Rigidbody magicRB = magicProjectile.GetComponent<Rigidbody>();
                    magicRB.AddForce(magicRB.transform.forward * speed);
                    Destroy(magicProjectile, 3f);
                }
            }
        }
    }
}

