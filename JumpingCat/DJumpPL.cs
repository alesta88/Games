using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DJumpPL : Platform
{
    public override void SetJump()
    {
        jumpForce *= 1.5f;
        SEManager.Instance.Play(SEManager.SE.JUMP);
        Debug.Log("DJ platform");
    }

}
