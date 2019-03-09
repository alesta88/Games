using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMy : MonoBehaviour {

    public Transform who;

    void Update()   
    {  
        if (who.position.y > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, who.position.y, transform.position.z);
        }
    }

}
