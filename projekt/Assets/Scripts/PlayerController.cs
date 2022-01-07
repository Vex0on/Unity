using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public float jumpForce;

    private Rigidbody2D myRigidbody;
    
    public bool onGround;
    public LayerMask whatIsGround;

    private Collider2D myCollider;

    private Animator myAnimator;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();

        myCollider = GetComponent<Collider2D>();

        myAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // Sprawdza czy posta� dotyka Collidera czyli ziemi
        onGround = Physics2D.IsTouchingLayers(myCollider, whatIsGround);

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
        // Animacja biegu i skoku
        myAnimator.SetFloat("Speed", myRigidbody.velocity.x);
        myAnimator.SetBool("OnGround", onGround);

    }
}
