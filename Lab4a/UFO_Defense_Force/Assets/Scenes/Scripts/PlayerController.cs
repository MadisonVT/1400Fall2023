using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;

    public float speed = 25;

    public float xRange = 23;

    public Transform blaster;

    public GameObject lazerBeam;

    public string inventory;
    
    
    public GameObject pickUp;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Set HorizontalInput to receive keyboard values
        horizontalInput = Input.GetAxis("Horizontal");
        
        // Moves player left and right
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        //Keeps player within bounds
        //Left side wall
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        //Right side wall
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        //If spacebar is pressed, fire lazerbeam.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Creates a lazerBeam at the blaster position while maintaining it's rotation.
            Instantiate(lazerBeam, blaster.transform.position, lazerBeam.transform.rotation);
        }
        
    }
    //Deletes any object that has a trigger that hits the player.
    private void OnTriggerEnter(Collider other)
    {
        inventory = "Gold ball thing";
        Debug.Log("You got " + inventory + "!");
        Destroy(other.gameObject);
        
    }
    
<<<<<<< HEAD
=======
    
>>>>>>> 01a4ed98a227bdfc62ad2c8f8f90e77705229436
}
