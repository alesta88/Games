﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectiles : MonoBehaviour {

    public float speed, damage;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        Atacker attacker = collider.gameObject.GetComponent<Atacker>();
        Health health = collider.gameObject.GetComponent<Health>();

        if (attacker && health)
        {
            health.DealDamage(damage);

         //   attacker.currentspeed = 0.01f; ////////////
            Destroy(gameObject);
           
        }
    }

}
