using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{

    float timer = 0.0f;
    public Text timeAlive;

    void Update()
    {
        timer += Time.deltaTime;
        float seconds = timer % 60;
        timeAlive.text = "Time: " + Mathf.Round(timer);
    }
}
