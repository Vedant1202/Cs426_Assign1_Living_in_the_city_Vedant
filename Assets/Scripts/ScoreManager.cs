using UnityEngine;
using TMPro;  // <-- Add this instead of UnityEngine.UI

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public int currentScore = 0;
    public TextMeshProUGUI scoreText;  // <-- Use TextMeshProUGUI here

    void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }

    public void AddScore(int value)
    {
        currentScore += value;
        UpdateScoreUI();
    }

    void UpdateScoreUI()
    {
        scoreText.text = "Score: " + currentScore;
    }
}
