using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public float timer = 60f;
    private bool gameEnded = false;
    public GameObject lostPanel;

    void Start()
    {
        timerText.text = timer.ToString("F0");
    }

    void Update()
    {
        if (!gameEnded)
        {
            timer -= Time.deltaTime;
            timerText.text = timer.ToString("F0");

            if (timer <= 0)
            {
                EndGame();
            }
        }
    }

    void EndGame()
    {
        gameEnded = true;
        Time.timeScale = 0f;
        lostPanel.SetActive(true);
    }
}