using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDownward : MonoBehaviour

{
    public float speed = 5.0f;
    public GameObject Player;
    
    
    // Update is called once per frame
    void Update()
    {
        //Moves GameObject backwards.
        transform.Translate(Vector3.back * (Time.deltaTime * speed));
    }
}