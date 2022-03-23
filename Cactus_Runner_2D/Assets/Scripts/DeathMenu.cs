using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{

    public string mainMenuLevel;

    public void RestartGame()
    {
        FindObjectOfType<GameManager>().Reset(); // Znajduje kod z GameManagera
    }

    public void ReturnToMain()
    {
        SceneManager.LoadScene(mainMenuLevel); //Laduje menu glowne
    }
}
