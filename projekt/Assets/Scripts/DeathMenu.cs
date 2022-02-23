using UnityEngine;

public class DeathMenu : MonoBehaviour
{

    public string mainMenuLevel;

    public void RestartGame()
    {
        FindObjectOfType<GameManager>().Reset(); // Znajduje kod z GameManagera
    }

    public void ReturnToMain()
    {
        Application.LoadLevel(mainMenuLevel); //Laduje menu glowne
    }
}
