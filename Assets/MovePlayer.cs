using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MovePlayer : MonoBehaviour
{
    [SerializeField]

    public Rigidbody2D rb;
    public float jumpAmount = 25;

    public bool playerIsGrounded ;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(
            Input.GetAxis("Horizontal") * 5f * Time.deltaTime,
            0f, 0f);

        if (Input.GetKeyDown(KeyCode.Space) && playerIsGrounded)
        {        
            rb.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);          
        }



    }
    private void OnCollisionStay2D(Collision2D Coll)
    {
        if (Coll.gameObject.tag == "Platform")
        {
            playerIsGrounded = true;

        }

            
    }
    private void OnCollisionExit2D(Collision2D Coll)
    {
        if (Coll.gameObject.tag == "Platform")
        {
            playerIsGrounded = false;

        }


    }




}
