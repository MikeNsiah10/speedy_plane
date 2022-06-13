using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int score;
    private int highscore;
    public Player Player;
    public Text score_text;
    public Text highscore_text;
    public GameObject gameOver;
    public GameObject play_button;
    // Start is called before the first frame update


    private void Awake()
    { //when game starts game should be paused
        pause_game();
    }
    public void play_game()
    {   //starting the game
        score = 0;
        score_text.text = score.ToString();
        highscore_text.text = "Highscore:" + highscore.ToString();
        highscore = PlayerPrefs.GetInt("highscore", 0);
        gameOver.SetActive(false);
        play_button.SetActive(false);
        Time.timeScale = 1f;
        Player.enabled = true;
        Obstacle[] obstacles = FindObjectsOfType<Obstacle>();

        for (int i = 0; i < obstacles.Length; i++)
        {
            Destroy(obstacles[i].gameObject);
        }
    }
    public void pause_game()
    {
        //pause everything in the game
        Time.timeScale = 0f;
        Player.enabled = false;

    }



    public void GameOver()
    {
        //set UI in game
        gameOver.SetActive(true);
        play_button.SetActive(true);
        highscore = PlayerPrefs.GetInt("highscore", 0);
       
        pause_game();
        
    }
    public void increase_score()
    {
        score++;
        score_text.text = " Score :" + score.ToString();
        if (highscore < score)
        {
            PlayerPrefs.SetInt("highscore", score);
        }
    }

}
