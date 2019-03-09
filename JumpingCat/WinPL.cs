using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinPL : Platform {

    public override void SetJump()
    {
        SEManager.Instance.Play(SEManager.SE.WIN);
        Player.IsPlaying = false;
        Time.timeScale = 0;
        SceneManager.LoadScene("GameClear", LoadSceneMode.Additive);

    }
}
