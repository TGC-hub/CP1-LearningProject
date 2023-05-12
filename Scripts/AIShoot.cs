using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIShoot : MonoBehaviour
{

    public GameObject deadEffect;

    public GameObject bulletAI;
    public GameObject BoomAI;

    public Transform vtBullet;
    public Transform vtBullet2;
    public Transform vtBoom;

    public float shootTime=1f;
    float boomTime = 20f;
    float nextShoot = 0.0f;
    float nextboom = 0.0f;

    public float bulletAIspeed = 22.5f;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if ( Time.time > nextShoot)
        {

            nextShoot = Time.time + shootTime;
            var bulletai = Instantiate(bulletAI, vtBullet.position, vtBullet.rotation);
            bulletai.GetComponent<Rigidbody2D>().velocity = vtBullet.up * bulletAIspeed;
            if(vtBullet2 != null)
            {
                var bulletai2 = Instantiate(bulletAI, vtBullet2.position, vtBullet2.rotation);
                bulletai2.GetComponent<Rigidbody2D>().velocity = vtBullet2.up * bulletAIspeed;
              
                
            }
          
        }

        if (BoomAI != null)
        {

            if (Time.time > nextboom)
            {
                nextboom = Time.time + boomTime;
                 Instantiate(BoomAI, vtBoom.position, vtBoom.rotation);

            }
        }

    }


}
