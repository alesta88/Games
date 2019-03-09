using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour {

	void Update () {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Player.IsPlaying = true;///yahooooooooooooooo
            Time.timeScale = 1;///
            SceneManager.LoadScene("Title");
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            Debug.Log("Exit");
        }
        if (Input.GetMouseButtonDown(0))
        {
            Player.IsPlaying = true;///yahooooooooooooooo
            Time.timeScale = 1;///
            SceneManager.LoadScene("Title");
        }
    }
}
