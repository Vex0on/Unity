using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text scoreText;
    public TMP_Text hiScoreText;

    public float scoreCount;
    public float hiScoreCount;

    public float pointsPerSecond;

    public bool scoreIncreasing;

    void Start()
    {
        if(PlayerPrefs.HasKey("HighScore"))
            hiScoreCount = PlayerPrefs.GetFloat("HighScore");
        hiScoreText.SetText("High Score: " + Mathf.Round(hiScoreCount));
    }

    void Update()
    {
        if(scoreIncreasing)
            scoreCount += pointsPerSecond * Time.deltaTime; // Dodawanie punktów wzglêdem ubywaj¹cego czasu

        scoreText.SetText("Score: " + Mathf.Round(scoreCount));
    }

    public void CheckToSaveHighScore()
    {
        if (scoreCount > hiScoreCount)
        {
            hiScoreCount = scoreCount;
            PlayerPrefs.SetFloat("HighScore", hiScoreCount);
            hiScoreText.SetText("High Score: " + Mathf.Round(hiScoreCount));
        }
    }

    public void AddScore(int pointsToAdd) => scoreCount += pointsToAdd;
}
