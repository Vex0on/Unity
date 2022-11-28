using UnityEngine;

public class CameraController : MonoBehaviour
{
    public PlayerController player;

    public float xOffset;

    private void Update()
    {
        transform.position = new Vector3(player.transform.position.x + xOffset, transform.position.y, transform.position.z);
    }
}
