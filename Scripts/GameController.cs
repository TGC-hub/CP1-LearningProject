using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public bool isEndGame;
    public GameObject panelEndGame;
    public GameObject openPanel;
    public GameObject textHD;
    AudioSource audioSource;
    public AudioClip MusicGame;
    public AudioClip GameOverClip;
    public AudioClip panelStartGameMusic;
    public AudioClip WinningMusic;
    GameObject controller;
    public GameObject HpPlayer;
    public GameObject HpBoss;
    public GameObject TheDoor;
 
    void Awake()
    {
        
        isEndGame = false;
        panelEndGame = GameObject.FindWithTag("PanelUI");
        if (SceneManager.GetActiveScene().buildIndex == 0 || SceneManager.GetActiveScene().buildIndex == 5)
        {
            HpBoss.SetActive(false);
            HpPlayer.SetActive(false);
            panelEndGame.SetActive(true);
            
        }
        else if (SceneManager.GetActiveScene().buildIndex == 4)
        {
            HpBoss.SetActive(true);
            panelEndGame.SetActive(false);

        }
        else
        {
           
            HpBoss.SetActive(false);    
            panelEndGame.SetActive(false);
        }
      


    }
    // Start is called before the first frame update
    void Start()
    {

        controller = gameObject;
        audioSource = controller.GetComponent<AudioSource>();
        if(SceneManager.GetActiveScene().buildIndex == 0)
        {
            audioSource.clip = panelStartGameMusic;
            audioSource.Play();
        }
        else if(SceneManager.GetActiveScene().buildIndex == 5)
        {
            audioSource.clip = WinningMusic;
            audioSource.Play();
        }else
        {
            audioSource.clip = MusicGame;
            audioSource.Play();
        }
        if (SceneManager.GetActiveScene().buildIndex == 2) { openPanel.SetActive(true); }
            if (SceneManager.GetActiveScene().buildIndex == 0) { textHD.SetActive(false); openPanel.SetActive(false); } else { openPanel.SetActive(true); }

        if (gameObject.tag == "Player"){
            HpPlayer.SetActive(true);
        }
       
      
        if(gameObject.tag == "Boss")
        {
            HpBoss.SetActive(true);
        }
     
      
   
    }
 
    void StartGame()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;

    }

    public void NewStart()
    {
        StartGame();
    }


    public void Cancel()
    {
        if (gameObject.tag == "Boss")
        {
            HpBoss.SetActive(true);
        }
        if (gameObject.tag == "Player")
        {
            HpPlayer.SetActive(true);
        }
        panelEndGame.SetActive(false);
        openPanel.SetActive(true);
        if(SceneManager.GetActiveScene().buildIndex == 0)
        {
            textHD.SetActive(true);
        }
        if (SceneManager.GetActiveScene().buildIndex == 2) { openPanel.SetActive(true); }


    }

   public void OpenPanel()
    {
        if (SceneManager.GetActiveScene().buildIndex == 2) { openPanel.SetActive(false); }
        panelEndGame.SetActive(true);
        openPanel.SetActive(false);
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            textHD.SetActive(false);
        }
        if (gameObject.tag == "Player")
        {
            HpPlayer.SetActive(false);
        }
        if (gameObject.tag == "Boss")
        {
            HpBoss.SetActive(false);
        }
    }


    public void Exit()
    {
        Application.Quit();
    }
 
    public void EndGame()
    {
        if (gameObject.tag == "Boss")
        {
            HpBoss.SetActive(false);
        }
        if (gameObject.tag == "Player")
        {
            HpPlayer.SetActive(false);
        }
        if (SceneManager.GetActiveScene().buildIndex == 2) { openPanel.SetActive(false); }
        openPanel.SetActive(false);
        panelEndGame.SetActive(true);

        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            textHD.SetActive(false);
        }

        isEndGame = true;
        Time.timeScale = 0;
        audioSource.clip = GameOverClip;
        audioSource.Play();
    }

   
}
