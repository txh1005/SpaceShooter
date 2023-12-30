using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameFlow : MonoBehaviour
{
    [SerializeField] private GameObject gameOverUI;
    [SerializeField] private GameObject gameWinUI;
    [SerializeField] private PlayerHealth playerHealth;
    [SerializeField] private GameObject bgMusic;
    // Start is called before the first frame update
    void Start()
    {
        gameOverUI.SetActive(false);
        gameWinUI.SetActive(false);
        playerHealth.onDead += OnGameOver();
    }
    private void Update()
    {
        if (EnemyHealth.LivingEnemyCount <= 0)
        {
            OnGameWin();
        }
    }

    private void OnGameWin()
    {
        gameOverUI.SetActive(true);
        bgMusic.SetActive(true);
        playerHealth.gameObject.SetActive(false);
    }

    public Action OnGameOver()
    {
        gameOverUI.SetActive(true);
        bgMusic.SetActive(false);
        return OnGameOver();
    }
    public void ReturnToMainMenu() => SceneManager.LoadScene("MainMenu");
}
