using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{

    public Transform generationPoint;
    public float distanceBetween;

    private float platformWidth;

    public float distanceBetweenMin;
    public float distanceBetweenMax;

    private int platformSelector;
    private float[] platformWidths;

    public ObjectPooler[] theObjectPools;

    // Odpala si� na starcie
    void Start()
    {

        platformWidths = new float[theObjectPools.Length]; //Array z d�ugo�ciami platform

        for (int i = 0; i < theObjectPools.Length; i++)
        {
            platformWidths[i] = theObjectPools[i].pooledObject.GetComponent<BoxCollider2D>().size.x; //Definiuje d�ugo�� platform
        }
    }

    // Aktualizuje si� z ka�dym frame'em
    void Update()
    {
        if(transform.position.x < generationPoint.position.x)
        {

            distanceBetween = Random.Range(distanceBetweenMin, distanceBetweenMax);

            platformSelector = Random.Range(0, theObjectPools.Length); //Losuje platforme spo�r�d podanych

            transform.position = new Vector3(transform.position.x + (platformWidths[platformSelector] / 2) + distanceBetween, transform.position.y, transform.position.z); //Pozycja nowej platformy

            //Instantiate(thePlatforms[platformSelector], transform.position, transform.rotation); //Kopiowanie i tworzenie nowych platform

            GameObject newPlatform = theObjectPools[platformSelector].GetPooledObject();

            newPlatform.transform.position = transform.position; //Ustawia platform� na wcze�niej ustawionym "platform.postion"
            newPlatform.transform.rotation = transform.rotation; //Upewnia si�, �e rotacja jest w�a�ciwa
            newPlatform.SetActive(true); //Aktywuje platformy

            transform.position = new Vector3(transform.position.x + (platformWidths[platformSelector] / 2), transform.position.y, transform.position.z); //Pozycja nowej platformy
        }
    }
}
