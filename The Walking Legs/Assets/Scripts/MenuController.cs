using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;
using UnityEngine.SceneManagement;



public class MenuController : MonoBehaviour
{

    public static bool gameIsPaused = false;
    public GameObject pauseMenu;
    public GameObject GameOverPanel;
    public AudioSource clickSound;

    private void Start()
    {
        clickSound = GetComponent<AudioSource>();
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPaused)
            {
                Resume();
                clickSound.Play();

            }
            else
            {
                Pause();
                clickSound.Play();

            }
        }

        GameOver();

        
    }

    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        Cursor.visible = true;
        gameIsPaused = true;
        
        
    }

    
    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = EnemySpawner.modifiedTime;
        Cursor.visible = false;
        gameIsPaused = false;
    }

    public void GameOver()
    {
        if (PlayerHealth.currentHealth <= 0f)
        {
            Time.timeScale = 0f;
            GameOverPanel.SetActive(true);


        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Game");
            ScoreScript.scoreValue = 0;
        }

    }


    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("quit");
    }   
}
