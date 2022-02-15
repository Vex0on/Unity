using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public Transform platformGenerator;
    private Vector3 platformStartPoint;

    public PlayerController thePlayer;
    private Vector3 playerStartPoint;

    private PlatformDestroyer[] platformList;

    private ScoreManager theScoreManager;

    // Start is called before the first frame update
    void Start()
    {
        // Ustalamy pozycje startowa dla generatora platform i dla gracza
        platformStartPoint = platformGenerator.position;
        playerStartPoint = thePlayer.transform.position;

        theScoreManager = FindObjectOfType<ScoreManager>();
    }

    // Update is called once per frame
    public void RestartGame()
    {
        StartCoroutine("RestartGameCo");
    }

    public IEnumerator RestartGameCo()
    {
        theScoreManager.scoreIncreasing = false;
        thePlayer.gameObject.SetActive(false); // Dezaktywuje postac w momencie smierci
        // Restartuje pozycje dla gracza i platformy do wartosci startowych
        yield return new WaitForSeconds(0.5f); // OpóŸnienie
        platformList = FindObjectsOfType<PlatformDestroyer>(); // Lista platform, ktore istnieja w momencie smierci
        for (int i = 0; i < platformList.Length; i++)
        {
            platformList[i].gameObject.SetActive(false); //  Platformy sie dezaktywuja
        }

        thePlayer.transform.position = playerStartPoint;
        platformGenerator.position = platformStartPoint;
        thePlayer.gameObject.SetActive(true); // Aktywuje ponownie postac

        theScoreManager.scoreCount = 0;
        theScoreManager.scoreIncreasing = true;
    }
}
