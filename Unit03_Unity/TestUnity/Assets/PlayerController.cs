using System;
using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float jumpForce = 5f;
    [SerializeField] private float gravity = 9.81f;

    private CharacterController characterController;
    private Vector3 moveDirection;
    private bool isJumping;
    // Use this for initialization
    void Start () {
    characterController = GetComponent<CharacterController>();
    }
    
    // Update is called once per frame
    void Update ()
    {
        //transform.position += Vector3.up * Time.deltaTime * moveSpeed;//
        float horizonInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        var moveDirection = new Vector3(horizonInput, verticalInput) * moveSpeed;
        if (Input.GetKeyDown(KeyCode.W))
        {
            characterController.Move(moveDirection * Time.deltaTime);
        }
    }
}