using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDownward : MonoBehaviour

{
    public float speed = 5.0f;
<<<<<<< HEAD
    
=======
    public GameObject Player;
>>>>>>> 01a4ed98a227bdfc62ad2c8f8f90e77705229436
    
    
    // Update is called once per frame
    void Update()
    {
        //Moves GameObject backwards.
        transform.Translate(Vector3.back * (Time.deltaTime * speed));
    }
}