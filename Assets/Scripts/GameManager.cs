using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int Score = 0; // An integer variable to hold the score

    public Text ScoreText; // A reference to a Text component to display the score

    public GameObject DeathScreen; // A reference to a UI panel for displaying the death screen

    void Start()
    {
        UpdateScore(true); // Calls the UpdateScore method to initialize the score text
    }

    void Update()
    {
        // Update method is currently empty, no logic implemented here
    }

    public void UpdateScore(bool init = false)
    {
        if (init == true)
        {
            ScoreText.text = Score.ToString(); // Set the score text to the initial score value
        }
        else
        {
            Score++; // Increment the score by 1
            ScoreText.text = Score.ToString(); // Update the score text with the new score value
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0); // Reload the scene (assuming scene 0 is the starting scene)
        Time.timeScale = 1; // Reset the time scale to resume the game
    }

    public void ShowDeathScreen()
    {
        DeathScreen.SetActive(true); // Activate the death screen UI panel to display it
    }
}