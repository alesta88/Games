using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour {

    

    public float jumpForce = 10f;

    public virtual void SetJump()
    {
        if (((Player.velcc <= 0) || Player.velcc == 10) && (Player.IsPlaying == true))
        {
            SEManager.Instance.Play(SEManager.SE.JUMP);
            Debug.Log("platform");
        }
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if ((collision.relativeVelocity.y<=0f)&&(Player.IsPlaying==true))//jump only in the top of the platform
        {
            Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                Vector2 velocity = rb.velocity;
                velocity.y = jumpForce;
                rb.velocity = velocity;
            }

         
        }
        
    }

    private void OnCollisionExit2D(Collision2D ob)
    {
        
    }

}
