using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour {

    AudioSource audioSource; 

    // Use this for initialization
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.time = 115f;   // assuming that you already have reference to your AudioSource
        audioSource.Play();
    }


    // Update is called once per frame
    void Update () {
		
	}
}
