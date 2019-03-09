using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Time.timeScale = 1;
        Spawn.ResetEnemy();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Title", LoadSceneMode.Single);
        }




       /* if (Input.GetKeyDown(KeyCode.Q))
        {
           
            SceneManager.LoadScene("GameOver", LoadSceneMode.Additive);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
           
           // IsPlaying = false;
          //  Time.timeScale = 0;///
            SceneManager.LoadScene("GameClear", LoadSceneMode.Additive);
        }*/
    }
}
