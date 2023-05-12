using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossShoot : MonoBehaviour
{
    public GameObject bulletBoss;
    public GameObject rocketBoss;
    public GameObject tankCon;

    public Transform VTBullet1;
    public Transform VTBullet2;
    public Transform VTBullet3;
    public Transform VTTankCon;
    public Transform VTRocket1;
    public Transform VTRocket2;

    float shootTime = 1f;
    float rocketTime = 10f;
    float tankConTime = 15f;

    float nextShoot = 0.0f;
    float nextRocket = 0.0f;
    float nextTankCon = 2.0f;

    float bulletAIspeed = 22.5f;
    float speedRocket= 25.0f;

    public GameObject bossDeadEffect;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextShoot)
        {

            nextShoot = Time.time + shootTime;

            var bulletboss = Instantiate(bulletBoss, VTBullet1.position, VTBullet1.rotation);
            bulletboss.GetComponent<Rigidbody2D>().velocity = VTBullet1.up  * bulletAIspeed;

            var bulletboss2 = Instantiate(bulletBoss, VTBullet2.position, VTBullet2.rotation);
            bulletboss2.GetComponent<Rigidbody2D>().velocity = VTBullet2.up * bulletAIspeed;

            var bulletboss3 = Instantiate(bulletBoss, VTBullet3.position, VTBullet3.rotation);
            bulletboss3.GetComponent<Rigidbody2D>().velocity = VTBullet3.up * bulletAIspeed;
        }

        if (Time.time > nextRocket)
        {

            nextRocket = Time.time + rocketTime;

            var boss = Instantiate(rocketBoss, VTRocket1.position, VTRocket1.rotation);
            boss.GetComponent<Rigidbody2D>().velocity = VTRocket1.up * speedRocket;

            var boss2 = Instantiate(rocketBoss, VTRocket2.position, VTRocket2.rotation);
            boss2.GetComponent<Rigidbody2D>().velocity = VTRocket2.up * speedRocket;

         
        }

        if (Time.time > nextTankCon)
        {
        
            nextTankCon = Time.time + tankConTime;
            Instantiate(tankCon, VTTankCon.position, VTTankCon.rotation);

        }

        if(gameObject == null)
        {
          
            Instantiate(bossDeadEffect, transform.position, transform.rotation);
        }

    }

}
