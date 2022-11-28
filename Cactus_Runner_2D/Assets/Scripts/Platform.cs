using UnityEngine;

public class Platform : MonoBehaviour
{
    private void Update()
    {
        if (transform.position.x < PlayerController.Instance.platformDestroyPoint.transform.position.x) //Wyszukuje punkt, w którym niszcz¹ siê platformy
            gameObject.SetActive(false); //Dezaktywuje stare platformy
    }
}
