using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public Text scoreText;
    public Text hiScoreText;

    public float scoreCount;
    public float hiScoreCount;

    public float pointsPerSecond;

    public bool scoreIncreasing;

    void Start()
    {
        // Zapisywanie wyniku dla gracza, nawet jesli wyjdzie z gry
        if(PlayerPrefs.HasKey("HighScore"))
        {
            hiScoreCount = PlayerPrefs.GetFloat("HighScore");
        }
    }

    void Update()
    {
        if(scoreIncreasing)
        {
            scoreCount += pointsPerSecond * Time.deltaTime; // Dodawanie punktów wzglêdem ubywaj¹cego czasu
        }

        // Jesli punkty przekraczaja highScore to highScore rosnie
        if (scoreCount > hiScoreCount)
        {
            hiScoreCount = scoreCount;
            PlayerPrefs.SetFloat("HighScore", hiScoreCount);
        }

        // Przypisanie tekstow ze sceny
        scoreText.text = "Score: " + Mathf.Round(scoreCount);
        hiScoreText.text = "High Score: " + Mathf.Round(hiScoreCount);

    }

    // Dodawania punktow
    public void AddScore(int pointsToAdd)
    {
        scoreCount += pointsToAdd;
    }
}
