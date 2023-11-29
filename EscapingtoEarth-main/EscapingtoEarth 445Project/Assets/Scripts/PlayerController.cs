using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Add RigidBody and Charachter controller component to player
// DO NOT USE A COLLIDER (That causes some problems)
public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float _gravity;
    [SerializeField]
    private float _playerSpeed;
    [SerializeField]
    private float _jumpHeight;
    [SerializeField]
    private float _yVelocity;
    CharacterController _controller;
    
    void Start()
    {
        _controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {

        
        float horizontalInput = Input.GetAxis("Horizontal");

        Vector3 direction = new Vector3(horizontalInput, 0, 0);

        Vector3 velocity = direction * _playerSpeed;

        _controller.Move(velocity * Time.deltaTime);

       

        
        velocity.y = _yVelocity;

        _controller.Move(velocity * Time.deltaTime);
        if (_controller.isGrounded == false)
        {
           _yVelocity -= _gravity;
        }
        else
        {

            if (Input.GetKey(KeyCode.W))
            {
                 _yVelocity = _jumpHeight;
            }
            
        }
    }
}
