using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Atacker))]
public class Bear : MonoBehaviour
{

    private Animator anim;
    private Atacker attacker;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        attacker = GetComponent<Atacker>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        GameObject obj = collider.gameObject;

        // Leave the method if not colliding with defender
        if (!obj.GetComponent<Defender>())
        {
            return;
        }

        anim.SetBool("IsAttacking", true);
        attacker.Attack(obj);
    }
}