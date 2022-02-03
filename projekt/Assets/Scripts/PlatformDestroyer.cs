using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDestroyer : MonoBehaviour
{

    public GameObject platformDestructionPoint;

    // Odpala si� na starcie
    void Start()
    {
        platformDestructionPoint = GameObject.Find("PlatformDestructionPoint");
    }

    // Aktualizuje si� z ka�dym frame'em
    void Update()
    {
        if(transform.position.x < platformDestructionPoint.transform.position.x) //Wyszukuje punkt, w kt�rym niszcz� si� platformy
        {
            //Destroy (gameObject);

            gameObject.SetActive(false); //Dezaktywuje stare platformy
        }

    }
}
