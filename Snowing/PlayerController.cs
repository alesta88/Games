using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

   Animator anim;
    float dirX = 5f;
    bool isDead;

    public float speed = 7;
    
    [Range(1, 10)]
    public float jumpvel;
    public float fall = 2.5f;
    public float lowJump = 2f;

    [SerializeField]
    private Transform GroundPoint;
    private bool isGround;
    public float checkRadius;
    public LayerMask whatIsGround;

    public int JumpCheck;



    Rigidbody2D rb;

    float screenHalfWidthInWorldUnits;

    // Use this for initialization

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    /*   private bool IsGround()
       {
           if(rb.velocity.y<=0)
       }*/
       
    void Start()
    {
        isDead = false;
        anim = GetComponent<Animator>();
        Score.scoreValue = 0;
        float halfPlayerWidth = transform.localScale.x / 2f - transform.localScale.x/2;
        screenHalfWidthInWorldUnits = Camera.main.aspect * Camera.main.orthographicSize + halfPlayerWidth;

    }

    private void FixedUpdate()
    {
        isGround = Physics2D.OverlapCircle(GroundPoint.position, checkRadius, whatIsGround);
       // Debug.Log(isGround);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 zvezdenscale = transform.localScale;


        if (isGround==true)
        {
            JumpCheck = 1;
        }


        float inputX = Input.GetAxisRaw("Horizontal");
        float velocity = inputX * speed;
        transform.Translate(Vector2.right * velocity * Time.deltaTime);

        if (transform.position.x < -screenHalfWidthInWorldUnits)
        {
            transform.position = new Vector2(screenHalfWidthInWorldUnits, transform.position.y);
        }
        if (transform.position.x > screenHalfWidthInWorldUnits)
        {
            transform.position = new Vector2(-screenHalfWidthInWorldUnits, transform.position.y);
        }


        if(Input.GetKeyDown(KeyCode.UpArrow) && JumpCheck>0)
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.up * jumpvel;
            JumpCheck--;
        }
        if(rb.velocity.y<0)
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (fall - 1) * Time.deltaTime;
        }
        else if(rb.velocity.y>0&&!Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (lowJump - 1) * Time.deltaTime;
        }

        SetAnimation();

        if (!isDead)
            dirX = Input.GetAxisRaw("Horizontal") * speed;

        if(inputX < 0)
        {
            zvezdenscale.x = -1;
        }
        if (inputX > 0)
        {
            zvezdenscale.x = 1;
        }
        transform.localScale = zvezdenscale;

    }

    void SetAnimation()
    {
        if (dirX == 0)
            anim.SetBool("isRunning", false);

        if (rb.velocity.y <= 0)
        {
            anim.SetBool("isJumping", false);
           // anim.SetBool("isRunning", false);
        }
            

        if(rb.velocity.y==0&&Mathf.Abs(dirX)>=5)
            anim.SetBool("isRunning", true);

        if (rb.velocity.y > 0)
            anim.SetBool("isRunning", false);       

    }

    void OnTriggerEnter2D(Collider2D triggerCollider)
    {
        if (triggerCollider.tag == "cube")
        {
            Destroy(gameObject);
            Time.timeScale = 0;
            isDead = true;
            dirX = 0;
            SceneManager.LoadScene("Over", LoadSceneMode.Additive);
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "sphere")
        {
            Score.scoreValue += 1;
            Destroy(collision.gameObject);
            if (Score.scoreValue==200)
            {
                Time.timeScale = 0;
                SceneManager.LoadScene("Clear", LoadSceneMode.Additive);
            }
        }
    }
}

