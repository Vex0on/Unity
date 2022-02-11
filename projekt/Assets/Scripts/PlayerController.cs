using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public float speedMultiplier;
    public float speedIncreaseMilestone;
    private float speedMilestoneCount;

    public float jumpForce;
    public float jumpTime;
    private float jumpTimeCounter;

    private Rigidbody2D myRigidbody;
    
    public bool onGround;
    public LayerMask whatIsGround;
    public Transform groundCheck;
    public float groundCheckRadius;

    //private Collider2D myCollider;

    private Animator myAnimator;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();

        //myCollider = GetComponent<Collider2D>();

        myAnimator = GetComponent<Animator>();

        jumpTimeCounter = jumpTime;

        speedMilestoneCount = speedIncreaseMilestone;
    }

    // Update is called once per frame
    void Update()
    {
        // Sprawdza czy posta� dotyka Collidera czyli ziemi
        onGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);

        // Gdy przekraczamy pewna pozycje to zaczynamy sie poruszac szybciej
        if(transform.position.x > speedMilestoneCount)
        {
            speedMilestoneCount += speedIncreaseMilestone;

            speedIncreaseMilestone = speedIncreaseMilestone * speedMultiplier; //Zwi�kszanie dystansu, w ktorym przyspieszamy
            moveSpeed = moveSpeed * speedMultiplier;
        }

        // Stale biegn�ca posta� w praw� stron�
        myRigidbody.velocity = new Vector2(moveSpeed, myRigidbody.velocity.y);

        // W momencie wci�ni�cia spacji lub LPM skaczemy z warto�ci� "jumpForce" tylko je�li spe�niamy warunek onGround
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0) )
        {
            if(onGround)
            {
                myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, jumpForce);
            }
        }

        // Gdy przytrzymujemy spacje/LPM to skaczemy wy�ej
        if(Input.GetKey(KeyCode.Space) || Input.GetMouseButton(0))
        {
            if(jumpTimeCounter > 0)
            {
                myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, jumpForce);
                jumpTimeCounter -= Time.deltaTime;
            }
        }

        // Gdy pu�cimy spacje/LPM to resetujemy Counter
        if(Input.GetKeyUp(KeyCode.Space) || Input.GetMouseButtonUp(0))
        {
            jumpTimeCounter = 0;
        }

        // Po powrocie na ziemie Counter wraca na 1
        if(onGround)
        {
            jumpTimeCounter = jumpTime;
        }

        // Animacja biegu i skoku
        myAnimator.SetFloat("Speed", myRigidbody.velocity.x);
        myAnimator.SetBool("OnGround", onGround);

    }
}
