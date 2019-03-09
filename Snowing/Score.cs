using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using TMPro;



public class Score : MonoBehaviour {

   // [SerializeField]
    public static int scoreValue = 0;
    Text score;
     
    
    // Use this for initialization
    void Start () {
        score = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        score.text = "Stars:  " + scoreValue+"/200";
	}
}
