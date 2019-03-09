using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       /* if (Input.GetKeyDown(KeyCode.Return))
        {
            //Player.IsPlaying = true;///
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
           // Player.IsPlaying = true;///
            Time.timeScale = 1;///
            SceneManager.LoadScene("Title");
        }*/
    }

    public void Restart()
    {
       
            Time.timeScale = 1;///
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
     
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Back()
    {
        Time.timeScale = 1;///
        SceneManager.LoadScene("Title", LoadSceneMode.Single);
    }


}