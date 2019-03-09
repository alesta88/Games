using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameClearManager : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      /*  if (Input.GetKeyDown(KeyCode.Return))
        {
           // Player.IsPlaying = true;///
            Time.timeScale = 1;///
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            Debug.Log("Exit");
        }
        if (Input.GetMouseButtonDown(0))
        {
            if (SceneManager.GetActiveScene().buildIndex <= 3)
            {
                // Player.IsPlaying = true;///
                Time.timeScale = 1;///
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            else
            {
                Time.timeScale = 1;///
                SceneManager.LoadScene("Title", LoadSceneMode.Single);
            }

        }*/
    }

    public void Next()
    {
        if (SceneManager.GetActiveScene().buildIndex <= 8)
        {
            // Player.IsPlaying = true;///
            Time.timeScale = 1;///
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            Time.timeScale = 1;///
            SceneManager.LoadScene("Title", LoadSceneMode.Single);
        }
    }

    public void Exit()
    {
        Application.Quit();
    }
    public void Back()
    {
        SEManager.Instance.Play(SEManager.SE.CHOOSE);
        SceneManager.LoadScene("Title", LoadSceneMode.Single);
    }

}