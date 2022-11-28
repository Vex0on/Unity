using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    [Header("PlatformGenerator")]
    public Transform generationPoint;

    [Header("Platform Distance")]
    public float distanceBetween;
    public float distanceBetweenMin;
    public float distanceBetweenMax;

    [Header("Platforms")]
    private int platformSelector;
    private float[] platformWidths;

    [Header("Object Pooling")]
    public ObjectPooler[] theObjectPools;

    [Header("Platform Height")]
    private float minHeight;
    public Transform maxHeightPoint;
    private float maxHeight;
    public float maxHeightChange;
    private float heightChange;

    [Header("Coin Generator sys")]
    public CoinGenerator coinGenerator;
    public float randomCoinThreshold;


    private void Start()
    {
        platformWidths = new float[theObjectPools.Length]; //Array z d³ugoœciami platform

        for (int i = 0; i < theObjectPools.Length; i++)
            platformWidths[i] = theObjectPools[i].pooledObject.GetComponent<BoxCollider2D>().size.x; //Definiuje d³ugoœæ platform

        // Definiujemy min i max wysokoœæ generowania platform
        minHeight = transform.position.y;
        maxHeight = maxHeightPoint.position.y;
    }

    private void Update()
    {
        if (transform.position.x < generationPoint.position.x)
        {
            distanceBetween = Random.Range(distanceBetweenMin, distanceBetweenMax);
            platformSelector = Random.Range(0, theObjectPools.Length); //Losuje platforme spoœród podanych
            heightChange = transform.position.y + Random.Range(maxHeightChange, -maxHeightChange); //Zmiana wysokoœci platform

            // Limit zmiany wysokoœci, ¿eby platformy nie ucieka³y poza obszar kamery
            if (heightChange > maxHeight)
                heightChange = maxHeight;
            else if (heightChange < minHeight)
                heightChange = minHeight;

            transform.position = new Vector3(transform.position.x + (platformWidths[platformSelector] / 2) + distanceBetween, heightChange, transform.position.z); //Pozycja nowej platformy

            GameObject newPlatform = theObjectPools[platformSelector].GetPooledObject();
            newPlatform.transform.SetPositionAndRotation(transform.position, transform.rotation); //Upewnia siê, ¿e rotacja jest w³aœciwa
            newPlatform.SetActive(true); //Aktywuje platformy

            if (Random.Range(0f, 100f) < randomCoinThreshold)
                coinGenerator.SpawnCoins(new Vector3(transform.position.x - 1.2f, transform.position.y + 0.5f, transform.position.z)); // Spawnowanie monet

            transform.position = new Vector3(transform.position.x + (platformWidths[platformSelector] / 2), transform.position.y, transform.position.z); //Pozycja nowej platformy
        }
    }
}
