using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupPoints : MonoBehaviour
{

    public int scoreToGive;

    private ScoreManager theScoreManager;

    // Start is called before the first frame update
    void Start()
    {
        theScoreManager = FindObjectOfType<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    // W momencie gdy gracz aktywuje collider coina (przez wejscie w niego)
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "Player")
        {
            theScoreManager.AddScore(scoreToGive); // To otrzymuje dodatkowe punkty
            gameObject.SetActive(false);
        }
    }
}
