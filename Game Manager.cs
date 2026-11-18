using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public enum State { Playing, Won, Lost }
    public State state = State.Playing;
    [SerializeField] int lives = 3;
    [SerializeField] TMP_Text livesText;
    public void LoseLife()
    {
        if (state != State.Playing) return;
        lives--;
        ShowLives();
        if (lives <= 0) Lose();
    }

    void Lose()
    {
        state = State.Lost;
    }
    void ShowLives()
    {
        if (livesText != null) livesText.text = "Lives: " + lives;
    }
}