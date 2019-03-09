using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JPlatform : MonoBehaviour
{
    private void OnCollisionExit2D(Collision2D ob)
    {

        if (ob.gameObject.tag == "Damage")
        {
            Time.timeScale = 0;///
            Debug.Log("OnCollisionEnter2D");
        }

    }

}