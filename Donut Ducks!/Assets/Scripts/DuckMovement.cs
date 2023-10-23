using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckMovement : MonoBehaviour
{
    [SerializeField] private float duckSpeed = 6;
    [SerializeField] private float duckJumpHeight = 6;
    [SerializeField] private LayerMask groundLayers;

    private new Rigidbody2D rigidbody;



    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
       
        PlayerMovement();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (GroundCheck())
            {

                Jump();
            }

        }
    }

    private bool GroundCheck()
    {

        float groundCheckRadius = 0.25f;
        RaycastHit2D hit = Physics2D.CircleCast(transform.position - new Vector3(0, -0.5f), groundCheckRadius, Vector2.down, 1, groundLayers);
        if (hit.transform != null)
        {
            return true;


        }
        else
        {
            return false;
        }


    }



    private void Jump()
    {

        rigidbody.AddForce(new Vector2(0, duckJumpHeight), ForceMode2D.Impulse);


    }


    private void PlayerMovement()
    {

        float movement = 0;
        if (Input.GetKey(KeyCode.A))
        {
            movement = -1;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            movement = 1;
        }

       
     

        rigidbody.velocity = new Vector3(movement * duckSpeed, rigidbody.velocity.y);


    }







}
