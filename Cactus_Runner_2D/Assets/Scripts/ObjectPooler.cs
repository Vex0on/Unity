using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
    public GameObject pooledObject;

    public int pooledAmount;

    public List<GameObject> pooledObjects;

    void Start()
    {
        pooledObjects = new List<GameObject>();

        for (int i = 0; i < pooledAmount; i++)
        {
            GameObject obj = Instantiate(pooledObject); //Castowanie obiektu
            obj.SetActive(false); //Dezaktywacja obiektu
            pooledObjects.Add(obj); //Dodanie obiektu do listy
        }
    }

    public GameObject GetPooledObject()
    {
        for (int i = 0; i < pooledObjects.Count; i++)
            if(!pooledObjects[i].activeSelf) //Sprawdza czy jest aktywne na aktualnej scenie
                return pooledObjects[i];

        GameObject obj = Instantiate(pooledObject);
        obj.SetActive(false);
        pooledObjects.Add(Instantiate(pooledObject));
        return obj;
    }
}
    
