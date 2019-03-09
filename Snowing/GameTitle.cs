using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameTitle : MonoBehaviour {

	void Update () {

        if (Input.GetKeyDown(KeyCode.Return))
        {
            Time.timeScale = 1;
            SceneManager.LoadScene("Game");
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            Debug.Log("Exit");
        }
    }
}
