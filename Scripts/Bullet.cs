using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    public int life = 3;
    public int damageBulletPlayer= 1;
    public GameObject bulletEffect;
 

    void Awake()
    {
        Destroy(gameObject, life);
  
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "TuongCanTro")
        {
            Destroy(Instantiate(bulletEffect, collision.transform.position, collision.transform.rotation), 5f);
            Destroy(collision.gameObject);
            Destroy(gameObject);


        }

        if (collision.gameObject.tag == "Enemy")
        {
            HeathAI heathAI = collision.gameObject.GetComponent<HeathAI>();
            heathAI.addDamage(damageBulletPlayer);
            Destroy(Instantiate(bulletEffect, collision.transform.position, collision.transform.rotation), 5f);
            Destroy(gameObject);

        }
        if (collision.gameObject.tag == "TuongGoc")
        {
            Destroy(Instantiate(bulletEffect, collision.transform.position, collision.transform.rotation), 5f);

            Destroy(gameObject);


        }
        if (collision.gameObject.tag == "BienGioiMap")
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Boss")
        {
            Destroy(Instantiate(bulletEffect, collision.transform.position, collision.transform.rotation), 5f);
            HeathAI heathAI = collision.gameObject.GetComponent<HeathAI>();
            heathAI.addDamage(damageBulletPlayer);
            Destroy(gameObject);

        }


    }

    

}
