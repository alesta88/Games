using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour {

    public int HMCost = 100;
    private Hachimitsu hachimitsu;

	// Use this for initialization
	void Start () {
        hachimitsu = GameObject.FindObjectOfType<Hachimitsu>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void AddHachimitsu(int amount)
    {
        hachimitsu.AddHachimitsu(amount);
    }
}
