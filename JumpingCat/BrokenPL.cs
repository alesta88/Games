using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BrokenPL : Platform {

    public override void SetJump()
    {
        if (((Player.velcc <= 0) || Player.velcc == 8) && (Player.IsPlaying == true))
        {
            SEManager.Instance.Play(SEManager.SE.DESTROY);
            Destroy(gameObject);
            Debug.Log("Broken");
        }
       
    }
}
