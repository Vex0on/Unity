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

    // Odpala siê na starcie
    void Start()
    {
        platformWidth = thePlatform.GetComponent<BoxCollider2D>().size.x; //Definiuje d³ugoœæ platformy
    }

    // Aktualizuje siê z ka¿dym frame'em
    void Update()
    {
        if(transform.position.x < generationPoint.position.x)
        {

            distanceBetween = Random.Range(distanceBetweenMin, distanceBetweenMax);

            transform.position = new Vector3(transform.position.x + platformWidth + distanceBetween, transform.position.y, transform.position.z); //Pozycja nowej platformy

            Instantiate(thePlatform, transform.position, transform.rotation); //Kopiowanie i tworzenie nowych platform
        }
    }
}
