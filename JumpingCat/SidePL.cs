using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SidePL : Platform {

    public override void SetJump()
    {
        SEManager.Instance.Play(SEManager.SE.GAMEOVER);
        Player.IsPlaying = false;
        Time.timeScale = 0;
        SceneManager.LoadScene("GameOver", LoadSceneMode.Additive);
       
    }
}
