using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    private void OnCollisionExit2D(Collision2D ob)
    {

        if (ob.gameObject.tag == "Win")
        {
            Debug.Log("Win");
            SEManager.Instance.Play(SEManager.SE.WIN);
            Player.IsPlaying = false;
            Time.timeScale = 0;
            SceneManager.LoadScene("GameClear", LoadSceneMode.Additive);
        }

    }
 
}
