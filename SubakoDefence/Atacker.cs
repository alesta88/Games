using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class Atacker : MonoBehaviour {


    internal Transform lane;

    [Tooltip("Average number of seconds between appearances")]
    public float seenEverySeconds;
    //  private float currentSpeed;
    [Range(-1f, 1.5f)]
    public float currentspeed;
    private GameObject currentTarget;
    private Animator animator;
  //  private Color32 BlueColor = new Color(127f, 179f, 255f);
    private float GameTimer = 0;
    public bool freeze=false;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * currentspeed * Time.deltaTime);
        if (!currentTarget)
        {
            animator.SetBool("IsAttacking", false);
        }

        GameTimer += Time.deltaTime;

    }

     private void OnTriggerEnter2D(Collider2D collision)
     {
         if (collision.gameObject.tag=="BlueHari")
         {
             print("blue");
             transform.GetChild(0).GetComponent<SpriteRenderer>().color = Color.blue;
           // SetSpeed(0.1f);
            freeze = true;
        }
     }



 public void SetSpeed(float speed)
    {
       /* if (gameObject.CompareTag("BlueHari"))
        {
            speed = 0.1f;
            
        }*/
        if ((freeze==true)&&(currentTarget))
        {
            currentspeed = 0f;
        } else
        {
            currentspeed = speed;
        }
        if ((freeze == true) && (!currentTarget))
        {
            currentspeed = speed/2;
        }
        else
        {
            currentspeed = speed;
        }



    }



    // Called from the animator at time of actual blow
    public void StrikeCurrentTarget(float damage)
    {
        if (currentTarget)
        {
            Health health = currentTarget.GetComponent<Health>();
            if (health)
            {
                health.DealDamage(damage);
            }
        }
    }

    public void Attack(GameObject obj)
    {
        currentTarget = obj;
    }
}