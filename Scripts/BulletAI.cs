using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class BulletAI : MonoBehaviour
{


    int life = 3;
    public int damageBullet;
    public GameObject BulletAIeffect;
    void Awake()
    {
        Destroy(gameObject, life);

    }



    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "TuongCanTro")
        {

            Destroy(Instantiate(BulletAIeffect, collision.transform.position, collision.transform.rotation), 5f);
            Destroy(collision.gameObject);
            Destroy(gameObject);

        }

        if (collision.gameObject.tag == "TuongGoc")
        {
            Destroy(Instantiate(BulletAIeffect, collision.transform.position, collision.transform.rotation), 5f);
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "BienGioiMap")
        {

            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Player")
        {
            Destroy(Instantiate(BulletAIeffect, collision.transform.position, collision.transform.rotation), 5f);
            TankScr tankScr = collision.gameObject.GetComponent<TankScr>();
            tankScr.addDamagePlayer(damageBullet);
            Destroy(gameObject);

        }
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(Instantiate(BulletAIeffect, collision.transform.position, collision.transform.rotation), 5f);
            Destroy(gameObject);


        }


    }

}
