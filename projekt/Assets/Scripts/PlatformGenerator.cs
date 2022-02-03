using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{

    public GameObject thePlatform;
    public Transform generationPoint;
    public float distanceBetween;

    private float platformWidth;

    public float distanceBetweenMin;
    public float distanceBetweenMax;

    public ObjectPooler theObjectPool;

    // Odpala si� na starcie
    void Start()
    {
        platformWidth = thePlatform.GetComponent<BoxCollider2D>().size.x; //Definiuje d�ugo�� platformy
    }

    // Aktualizuje si� z ka�dym frame'em
    void Update()
    {
        if(transform.position.x < generationPoint.position.x)
        {

            distanceBetween = Random.Range(distanceBetweenMin, distanceBetweenMax);

            transform.position = new Vector3(transform.position.x + platformWidth + distanceBetween, transform.position.y, transform.position.z); //Pozycja nowej platformy

            //Instantiate(thePlatform, transform.position, transform.rotation); //Kopiowanie i tworzenie nowych platform
            GameObject newPlatform = theObjectPool.GetPooledObject();

            newPlatform.transform.position = transform.position; //Ustawia platform� na wcze�niej ustawionym "platform.postion"
            newPlatform.transform.rotation = transform.rotation; //Upewnia si�, �e rotacja jest w�a�ciwa
            newPlatform.SetActive(true); //Aktywuje platformy
        }
    }
}
