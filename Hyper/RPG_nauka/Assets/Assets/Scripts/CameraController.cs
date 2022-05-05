using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public PlayerController thePlayer;
    private Vector2 lastPlayerPosition;

    void Start()
    {
        thePlayer = FindObjectOfType<PlayerController>();
        lastPlayerPosition = thePlayer.transform.position;
    }

    void LateUpdate()
    {
        transform.position = new Vector3(transform.position.x + (thePlayer.transform.position.x - lastPlayerPosition.x), transform.position.y + (thePlayer.transform.position.y - lastPlayerPosition.y), -10);
        lastPlayerPosition = thePlayer.transform.position;
    }
}
