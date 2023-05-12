using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TheDoor : MonoBehaviour
{
    public GameObject gameController;
     float Sodichcangiet;
     public GameObject[] findEnemy;
     public GameObject[] findBoss;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        DemSoDich();
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {


         
        if(collision.gameObject.tag == "Bullet")
        {
            EndGame();

        }


        if(collision.gameObject.tag == "Player")
        {
            if(SceneManager.GetActiveScene().buildIndex == 4)
            {
                
                if (Sodichcangiet == 0)
                {
                    NextScene();
                }
            }
            else
            {
                if (findEnemy.LongLength == 0)
                {
                    NextScene();
                }
            }

        
        }

        
    }

   

    private void NextScene()
    {
       


        int sceneIndex = SceneManager.GetActiveScene().buildIndex;

        int nextSceneIndex = sceneIndex + 1;

        if (nextSceneIndex < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(nextSceneIndex);
        }

        
    
    }

    void DemSoDich()
    {
        findBoss = GameObject.FindGameObjectsWithTag("Boss");
        findEnemy = GameObject.FindGameObjectsWithTag("Enemy");
        Sodichcangiet = findEnemy.LongLength + findBoss.LongLength;

    }

    void EndGame()
    {
      
        gameController.GetComponent<GameController>().EndGame();
    }
}
