using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public string mainMenuLevel;

    public GameObject pauseMenu;

    public void PauseGame()
    {
        Time.timeScale = 0f; // Zatrzymuje czas
        pauseMenu.SetActive(true);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P))
        {
            Time.timeScale = 0f; // Zatrzymuje czas
            pauseMenu.SetActive(true);
        }
    }
    
public void ResumeGame()
    {
        Time.timeScale = 1f; //Przywraca czas do normalnosci
        pauseMenu.SetActive(false);
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        FindObjectOfType<GameManager>().Reset(); // Znajduje kod z GameManagera
        pauseMenu.SetActive(false);
    }

    public void ReturnToMain()
    {
        Time.timeScale = 1f;
        Application.LoadLevel(mainMenuLevel); //Laduje menu glowne
        pauseMenu.SetActive(false);
    }
}
