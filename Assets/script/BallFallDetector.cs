using UnityEngine;

public class BallFallDetector : MonoBehaviour
{
    public GameManager gameManager; // ��� �� GameManager

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            gameManager.LoseGame();
        }
    }
}
