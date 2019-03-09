using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DamagePL : Platform {

    public override void SetJump()
    {
        if (((Player.velcc <= 0) || Player.velcc == 5))
        {
            SEManager.Instance.Play(SEManager.SE.DAMAGE);
            Player.IsPlaying = false;
            Destroy(gameObject.GetComponent<Collider>());
            Player.movementSpeed = 0f;
            Debug.Log("Damage platform");
            SceneManager.LoadScene("GameOver", LoadSceneMode.Additive);
        }
    }
}
