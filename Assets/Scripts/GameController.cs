using UnityEngine;

public class GameController : MonoBehaviour
{
    public Ball ball;
    private int _playerScore;
    private int _computerScore;

    public void PlayerScores()
    {
        _playerScore++;

        ball.ResetPosition();
    }

    public void ComputerScores()
    {
        _computerScore++;

        ball.ResetPosition();
    }
}
