using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float forwardForce; // launch force of ball.
    // left / right movement.
    public float leftBorder;
    public float rightBorder;
    // L/R Move incremenet;
    public float moveIncrement;
    public Rigidbody rig;



    public void Bowl()
    {
        rig.AddForce(transform.forward * forwardForce, ForceMode.Impulse);
    }

    // get current postion, move to left.
    public void MoveLeft()
    {
        if (transform.position.x > leftBorder)
        {
            transform.position += new Vector3(-moveIncrement, 0, 0);
        }
    }

    public void MoveRight()
    {
        if(transform.position.x < rightBorder)
        {
            transform.position += new Vector3(moveIncrement, 0, 0);
        }
    }

    
}
