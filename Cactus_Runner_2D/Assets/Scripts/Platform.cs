using UnityEngine;

public class Platform : MonoBehaviour
{
    private void Update()
    {
        if (transform.position.x < PlayerController.Instance.platformDestroyPoint.transform.position.x) //Wyszukuje punkt, w kt�rym niszcz� si� platformy
            gameObject.SetActive(false); //Dezaktywuje stare platformy
    }
}
