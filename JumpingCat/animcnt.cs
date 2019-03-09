using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class animcnt : MonoBehaviour {

    public Animator animat;
    
	// Use this for initialization
	void Start () {
        animat = GetComponent<Animator>();

	}

    public void jumping()
    {
        animat.Play("Jump");
    }
    public void Attack()
    {
        animat.Play("Attack");
    }
    public void jumping2()
    {
        animat.Play("Jump2");
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKey("up"))
        {
            animat.Play("Arm");
        }
		
	}
}
