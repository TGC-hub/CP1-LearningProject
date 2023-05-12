using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HeathAI : MonoBehaviour
{
    public Text HpBoss;
    public int maxHealth;
    int currenHealth;
    // Start is called before the first frame update
    void Start()
    {
           currenHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetHPBoss()
    {
        HpBoss.text = "Boss : " + currenHealth.ToString();
    }
    public void addDamage(int damage)
    {
        currenHealth -= damage;

        if(gameObject.tag == "Boss")
        {
            GetHPBoss();
        }
        if(currenHealth <= 0)
        {
            makeDead();
        }
    }

    public void makeDead()
    {
        Destroy(gameObject);
    }


}
