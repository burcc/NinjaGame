using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static Vector2 bottomLeft;
    public static bool gameOver;
    public GameObject gameOverPanel;
    public GameObject topScore;
    public GameObject pauseScreen;
    private bool paused;
    public GameObject pauseParent;
    public GameObject playParent;
    
    
    // Start is called before the first frame update
    private void Awake()
    {
        bottomLeft = Camera.main.ScreenToWorldPoint(new Vector2(0, 0));
    }
    public void RestartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    void Start()
    {
        gameOver = false;
        
    }
    public void GameOver()
    {
        gameOver = true;
        gameOverPanel.SetActive(true);
        topScore.SetActive(false);
        pauseParent.SetActive(false);
        playParent.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene(1);
    }
    public void ChangePaused()
    {
        if (!paused)
        {
            paused = true;
            pauseScreen.SetActive(true);
            Time.timeScale = 0;
            pauseParent.SetActive(false);
            playParent.SetActive(true);
        }
        
    }
    public void PlayButton()
    {
        paused = false;
        pauseScreen.SetActive(false);
        Time.timeScale = 1;
        pauseParent.SetActive(true);
        playParent.SetActive(false);
    }
}
