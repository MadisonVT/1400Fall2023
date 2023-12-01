using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackward : MonoBehaviour
{
    public float speed = 50.0f;

    // Update is called once per frame
    void Update()
    {
        //Moves GameObject backward.
        transform.Translate(Vector3.back * (Time.deltaTime * speed));
    }
}