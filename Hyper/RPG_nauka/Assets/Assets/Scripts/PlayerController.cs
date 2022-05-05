using UnityEngine;
using Unity.Collections;
using System;

public class PlayerController : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] private Rigidbody2D rb;

    [Header("Speed Values")]
    public float speed;
    public float sprintSpeed;
    public Vector2 inputDir;
    [ReadOnly] public float currentSpeed;
    [ReadOnly] private float lerpSpeed = 2f;

    [Header("Objects")]
    public GameObject Phone;
    public GameObject Canvas;
    public GameObject Equipment;

    private int lastPressed = 0;

    private void Update()
    {
        GameInputs();
        inputDir = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        inputDir = inputDir.normalized;
    }
    protected void FixedUpdate()
    {
        rb.MovePosition(rb.position + currentSpeed * Time.deltaTime * inputDir);
    }

    protected void Awake()
    {
        currentSpeed = speed;
    }

    private void GameInputs()
    {
        //Hold Shift to sprint
        if (Input.GetKey(KeyCode.LeftShift))
            currentSpeed = Mathf.Lerp(currentSpeed, sprintSpeed, lerpSpeed * Time.deltaTime);
        else
            currentSpeed = Mathf.Lerp(currentSpeed, speed, lerpSpeed * Time.deltaTime);

        //Press ESC to open Phone
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (lastPressed == 0)
            {
                PhoneON();
                lastPressed = 1;
            }
            else if (lastPressed == 1)
            {
                PhoneOFF();
                lastPressed = 0;
            }
            
            //Phone.SetActive(!Phone.activeSelf);
        }

        //Press I to open Equipment
        if (Input.GetKeyDown (KeyCode.I))
        {
            Equipment.SetActive(!Equipment.activeSelf);
        }
            
    }

    public void PhoneON()
    {
        Phone.SetActive(true);
    }

    public void PhoneOFF()
    {
        Phone.SetActive(false);
    }

    public void MainMenuWorking()
    {
        Canvas.SetActive(!Canvas.activeSelf);
        Time.timeScale = Canvas.activeSelf ? 0 : 1;
    }

    public void EquipmentWorking()
    {
        Equipment.SetActive(!Equipment.activeSelf);
        Phone.SetActive(false); //Jeœli otworzymy ekwipunek to zamyka siê telefon
    }

    /*public void MainMenuON()
    {
        Canvas.SetActive(true);
        Time.timeScale = 0f;
    }

    public void MainMenuOFF()
    {
        Canvas.SetActive(false);
        Time.timeScale = 1f;
    }*/
}
