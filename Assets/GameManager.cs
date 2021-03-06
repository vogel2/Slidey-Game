﻿using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public bool IsGameOver = false;
    public Text GameOverText;
    public GameObject WinScreen;

    public void EndGame()
    {
        GameOverText.text = "Press Spacebar to Restart";
        if (Input.GetKey(KeyCode.Space))
        {
            if (IsGameOver == false)
            {
                Debug.Log("Game Over!");
                IsGameOver = true;
                Restart();
            }   
        }

    }

    void Restart()
    {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void WinGame()
    {
        WinScreen.SetActive(true);
    }
}
