using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string playGameLevel;

    public GameObject optionsScreen;

    public void PlayGame() => SceneManager.LoadScene(playGameLevel);
    public void Quit() => Application.Quit();

    public void OpenOptions() => optionsScreen.SetActive(true);
    public void CloseOptions() => optionsScreen.SetActive(false);
}
