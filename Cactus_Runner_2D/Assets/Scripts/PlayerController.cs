using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public static PlayerController Instance { get; private set; }

    [Header("Speed")]
    public float moveSpeed;
    private float moveSpeedStore;
    public float speedMultiplier;

    public float speedIncreaseMilestone;
    private float speedIncreaseMilestoneStore;
    private float speedMilestoneCount;
    private float speedMilestoneCountStore;

    [Header("Jump")]
    public float jumpForce;
    public float jumpTime;
    private float jumpTimeCounter;
    private bool stoppedJumping;

    [Header("Components")]
    private Rigidbody2D myRigidbody;

    [Header("Ground Detection")]
    public bool onGround;
    public LayerMask whatIsGround;
    public Transform groundCheck;
    public float groundCheckRadius;

    //private Collider2D myCollider;
    [Header("Animation")]
    private Animator animator;

    [Header("Ogolne")]
    public CanvasController canvasController;
    public GameObject platformDestroyPoint;

    private void Start()
    {
        Instance = this;

        myRigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

        jumpTimeCounter = jumpTime;

        speedMilestoneCount = speedIncreaseMilestone;

        moveSpeedStore = moveSpeed;
        speedMilestoneCountStore = speedMilestoneCount;
        speedIncreaseMilestoneStore = speedIncreaseMilestone;
    }

    private void Update()
    {
        // Sprawdza czy postaæ dotyka Collidera czyli ziemi
        onGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);

        // Gdy przekraczamy pewna pozycje to zaczynamy sie poruszac szybciej
        if (transform.position.x > speedMilestoneCount)
        {
            speedMilestoneCount += speedIncreaseMilestone;

            speedIncreaseMilestone *= speedMultiplier; //Zwiêkszanie dystansu, w ktorym przyspieszamy
            moveSpeed *= speedMultiplier;
        }

        // Stale biegn¹ca postaæ w praw¹ stronê
        myRigidbody.velocity = new Vector2(moveSpeed, myRigidbody.velocity.y);

        // W momencie wciœniêcia spacji lub LPM skaczemy z wartoœci¹ "jumpForce" tylko jeœli spe³niamy warunek onGround
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            if (onGround)
            {
                myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, jumpForce);
                stoppedJumping = false;
            }
        }

        // Gdy przytrzymujemy spacje/LPM to skaczemy wy¿ej
        if ((Input.GetKey(KeyCode.Space) || Input.GetMouseButton(0)) && !stoppedJumping)
        {
            if (jumpTimeCounter > 0)
            {
                myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, jumpForce);
                jumpTimeCounter -= Time.deltaTime;
            }
        }

        // Gdy puœcimy spacje/LPM to resetujemy Counter
        if (Input.GetKeyUp(KeyCode.Space) || Input.GetMouseButtonUp(0))
        {
            jumpTimeCounter = 0;
            stoppedJumping = true;
        }
        // Po powrocie na ziemie Counter wraca na 1
        if (onGround)
            jumpTimeCounter = jumpTime;

        // Animacja biegu i skoku
        animator.SetFloat("Speed", myRigidbody.velocity.x);
        animator.SetBool("OnGround", onGround);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("killbox"))
        {
            canvasController.scoreManager.scoreIncreasing = false;
            canvasController.deathMenu.SetActive(true); // W³acza ekran smierci

            // Restart predkosci postaci w momencie smierci do wartosci poczatkowej
            moveSpeed = moveSpeedStore;
            speedMilestoneCount = speedMilestoneCountStore;
            speedIncreaseMilestone = speedIncreaseMilestoneStore;

            canvasController.scoreManager.CheckToSaveHighScore();

            gameObject.SetActive(false); // Dezaktywuje postac w momencie smierci
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.TryGetComponent<Coin>(out var coin))
        {
            canvasController.scoreManager.AddScore(coin.scoreToGive);
            coin.gameObject.SetActive(false);
        }
    }
}
