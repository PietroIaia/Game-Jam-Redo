using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    // Private variables
    [SerializeField] private CharacterController2D controller;
    [SerializeField] private float runSpeed = 15f;
    private float horizontalMove = 0f;
    private bool jump = false;


    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        if ( Input.GetButtonDown("Jump") ) { jump = true; }
    }
    

    // Update is called once per frame
    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}