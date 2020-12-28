using UnityEngine;

public class FinishTrigger : MonoBehaviour
{
    public GameManager gameManager;
    public PlayerMovement movement;
    public Score score;

    private void OnTriggerEnter()
    { 
        gameManager.WinGame();
        movement.enabled = false;
        score.ScoreText.text = "";
        score.enabled = false;
    }
}
