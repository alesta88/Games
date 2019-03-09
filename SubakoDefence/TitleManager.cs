using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour {

    //private static bool created = false;
    public Transform who;
   /* void Awake()
    {
        if (!created)
        {
            DontDestroyOnLoad(who.gameObject);
            created = true;
            Debug.Log("Awake: " + this.gameObject);
        }
    }*/
    public void StartGame()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        SEManager.Instance.Play(SEManager.SE.CHOOSE);
        SceneManager.LoadScene("ChoosingLevel", LoadSceneMode.Single);
    }

    public void Level1()
    {
        SEManager.Instance.Play(SEManager.SE.CHOOSE);
        SceneManager.LoadScene("Level1", LoadSceneMode.Single);
    }
    public void Level2()
    {
        SEManager.Instance.Play(SEManager.SE.CHOOSE);
        SceneManager.LoadScene("Level2", LoadSceneMode.Single);
    }
    public void Level3()
    {
        SEManager.Instance.Play(SEManager.SE.CHOOSE);
        SceneManager.LoadScene("Level3", LoadSceneMode.Single);
    }
    public void Level4()
    {
        SEManager.Instance.Play(SEManager.SE.CHOOSE);
        SceneManager.LoadScene("Level4", LoadSceneMode.Single);
    }
    public void Level5()
    {
        SEManager.Instance.Play(SEManager.SE.CHOOSE);
        SceneManager.LoadScene("Level5", LoadSceneMode.Single);
    }
    public void Level6()
    {
        SEManager.Instance.Play(SEManager.SE.CHOOSE);
        SceneManager.LoadScene("Level6", LoadSceneMode.Single);
    }
    public void Level7()
    {
        SEManager.Instance.Play(SEManager.SE.CHOOSE);
        SceneManager.LoadScene("Level7", LoadSceneMode.Single);
    }
    public void Level8()
    {
        SEManager.Instance.Play(SEManager.SE.CHOOSE);
        SceneManager.LoadScene("Level8", LoadSceneMode.Single);
    }


    public void Back()
    {
        SEManager.Instance.Play(SEManager.SE.CHOOSE);
        SceneManager.LoadScene("Title", LoadSceneMode.Single);
    }
    public void Exit()
    {
        SEManager.Instance.Play(SEManager.SE.CHOOSE);
        Application.Quit();
    }
}
