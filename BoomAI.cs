using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomAI : MonoBehaviour
{
   
    public int damageboom = 2;
    public GameObject BoomEffect;




    void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == "Player")
        {
            
            Destroy(Instantiate(BoomEffect, collision.transform.position, collision.transform.rotation), 5f);
            TankScr tankScr = collision.gameObject.GetComponent<TankScr>();
            tankScr.addDamagePlayer(damageboom);
            Destroy(gameObject);

        }
       

    }
}
