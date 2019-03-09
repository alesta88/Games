using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideScr : MonoBehaviour {


    public Transform who2;

    void Update()
    {
        if (who2.position.y > transform.position.y-5.5)
        {
            transform.position = new Vector3(transform.position.x, who2.position.y-6, transform.position.z);
        }
    }
}
