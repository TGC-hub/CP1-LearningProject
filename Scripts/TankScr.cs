using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class TankScr : MonoBehaviour
{
    public Transform VTDanBan;
    public GameObject bulletPrefab;
    public GameObject gameController;
    public GameObject deadEffect;

    public float bulletSpeed = 17f;
    public float moveSpeed = 8f;

    public int maxhealthPlayer = 10;
    int healthplayer;
 
    Animator anim;

    public AudioClip shooting;
    AudioSource audioSource;

    public Text yourHP;
    bool isPlayerDead;
     void Awake()
    {
        healthplayer = maxhealthPlayer;
    }
    // Start is called before the first frame update
    void Start()
    {
       
        anim = GetComponentInChildren<Animator>();
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = shooting;
        isPlayerDead = false;
    }
   
    void Update()
    {
        
        if(isPlayerDead == false)
        {
            Movement();
            Shooting();
        }
            

    }

    void Movement()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        if (h != 0)
        {

/*            anim.SetBool("MoveTrack", true);*/
            transform.position += new Vector3(h * moveSpeed * Time.deltaTime, 0, 0);
            transform.rotation = Quaternion.Euler(0, 0, -90 * h);
        }
        else if (v != 0)
        {

    /*        anim.SetBool("MoveTrack", true);*/
            transform.position += new Vector3(0, v * moveSpeed * Time.deltaTime, 0);
            transform.rotation = Quaternion.Euler(0, 0, 90 - 90 * v);
        }
        else
        {

           /* anim.SetBool("MoveTrack", false);*/
        }

    }

    void Shooting()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var bullet = Instantiate(bulletPrefab, VTDanBan.position, VTDanBan.rotation);
            bullet.GetComponent<Rigidbody2D>().velocity = VTDanBan.up * bulletSpeed;
           
                audioSource.Play();
         
        }
    }

    public void GetHP()
    {
        yourHP.text = "Your HP : " + healthplayer.ToString();
    }
    public void addDamagePlayer(int damage)
    {
    
        healthplayer -= damage;
        GetHP();
        if (healthplayer <= 0)
        {
            makePlayerDead();
           
        }
    }

    public void makePlayerDead()
    {
        Instantiate(deadEffect, transform.position, transform.rotation);
        Destroy(gameObject);
        EndGame();
    }


    void EndGame()
    {
        
        isPlayerDead = true;
        gameController.GetComponent<GameController>().EndGame();
       
    }
}
