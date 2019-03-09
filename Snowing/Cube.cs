using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {

    public float speed = 25;


    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }
}
