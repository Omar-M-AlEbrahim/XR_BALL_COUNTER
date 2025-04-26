using UnityEngine;
using TMPro;

public class BallCounter : MonoBehaviour
{
    [Header("UI Reference")]
    public TextMeshProUGUI counterText;

    [Header("Game Management")]
    public GameManager gameManager; // ÑÈØ ãÚ GameManager
    public int totalBalls = 5; // ÚÏÏ ÇáßÑÇÊ ÇáãØáæÈ äÞáåÇ

    private int count = 0;

    private void Start()
    {
        UpdateCounterText();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            count++;
            UpdateCounterText();
            CheckWinCondition();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            count--;
            UpdateCounterText();
        }
    }

    private void UpdateCounterText()
    {
        if (counterText != null)
        {
            counterText.text = "Number of balls in the box: " + count.ToString();
        }
        else
        {
            Debug.LogWarning("Counter Text not assigned!");
        }
    }

    private void CheckWinCondition()
    {
        if (count >= totalBalls)
        {
            gameManager.WinGame();
        }
    }
}
