using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour
{

    public float health = 100f;

    void Start()
    {
      
    }


        public void DealDamage(float damage)
    {

        if (gameObject.CompareTag("Teki"))
        {
            SEManager.Instance.Play(SEManager.SE.TDAMAGE);

        }
        else
        {
            SEManager.Instance.Play(SEManager.SE.DAMAGE);
        }

        
        health -= damage;
        if (health < 0)
        {
            // Optionally trigger animation
            SEManager.Instance.Play(SEManager.SE.DESTROY);
            DestoryObject();
            if (gameObject.CompareTag("Teki"))
            {
                SEManager.Instance.Play(SEManager.SE.TDESTROY);
                Spawn.SubEnemy();
            }
        }
    }

    public void DestoryObject()
    {
        Destroy(gameObject);
    }



}