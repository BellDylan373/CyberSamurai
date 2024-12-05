using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool GamePaused = false;

    [SerializeField] GameObject pauseMenuUI;
    void Awake()
    {
        pauseMenuUI.SetActive(false);
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(GamePaused)
            {
                pauseMenuUI.SetActive(false);
                Time.timeScale =1;
                GamePaused = false;
            } else 
            {
                pauseMenuUI.SetActive(true);
                Time.timeScale = 0;
                GamePaused = true;
            }

        }

        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            Time.timeScale = Time.timeScale/2;
        }
        if(Input.GetKeyUp(KeyCode.LeftShift))
        {
            Time.timeScale =Time.timeScale*2;
        }
    }

     public void ResumeGame()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale =1;
        GamePaused = false;
    }
    public void PauseGame()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0;
        GamePaused = true;
    }

    public void QuitGame()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
