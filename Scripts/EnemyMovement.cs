using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyMovement : MonoBehaviour
{

  /*  NavMeshAgent agent;
    public Transform[] waypoint;
    int waypointIndext;
    Vector3 target;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();   
    }
    void Update()
    {
            if(Vector3.Distance(transform.position, target)<1)
        {
            IterateWaypointIndex();
            UpdateDestination();
        }     
    }

    void UpdateDestination()
    {
        target = waypoint[waypointIndext].position;
        agent.SetDestination(target);

    }

    void IterateWaypointIndex()
    {
        waypointIndext++;
        if(waypointIndext == waypoint.Length)
        {
            waypointIndext = 0;

        }
    }

*/




    /*public float enemySpeed;
    Rigidbody rb;
    public GameObject enemyGraphic;
    bool facingRight = true;
    float facingTime = 5f;
    float nextFlip = 0f;
    bool canFlip = true;


    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > nextFlip)
        {
            nextFlip = Time.time + facingTime;
            flipY();
          
        }
    }

    public void flipY()
    {
        *//*        facingRight = !facingRight;
                Vector3 theScale = enemyGraphic.transform.localScale;
                theScale.x *= -1;
                enemyGraphic.transform.localScale = theScale;
        *//*
        facingRight = !facingRight;
        Quaternion quaternion =  enemyGraphic.transform.localRotation;
        quaternion.z *=-1 ;
        enemyGraphic.transform.localRotation = quaternion;
    }
*/





}
