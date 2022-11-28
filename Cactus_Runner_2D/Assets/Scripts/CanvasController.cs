using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasController : MonoBehaviour
{
    public ScoreManager scoreManager;

    public GameObject pauseMenu;
    public GameObject deathMenu;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P))
            PauseGame();
    }

    public void PauseGame()
    {
        Time.timeScale = 0f; // Zatrzymuje czas
        pauseMenu.SetActive(true);
    }
    public void ResumeGame()
    {
        Time.timeScale = 1f; //Przywraca czas do normalnosci
        pauseMenu.SetActive(false);
    }

    public void RestartGame() => SceneManager.LoadScene(1);
    public void ReturnToMain() => SceneManager.LoadScene(0);
}
