using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmalPL : Platform {

    public override void SetJump()
    {
        jumpForce =6f;
        SEManager.Instance.Play(SEManager.SE.JUMP);

    }

}
