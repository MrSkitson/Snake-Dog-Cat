using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snake : MonoBehaviour
{
    private Vector2 _direction = Vector2.right;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            _direction = Vector2.up;
        } else if (Input.GetKeyDown(KeyCode.S))
        {
            _direction = Vector2.down;
        } else if(Input.GetKeyDown(KeyCode.D))
        {
            _direction = Vector2.right;
        } else if( Input.GetKeyDown(KeyCode.A))
        {
            _direction = Vector2.left;
        }    

    }
}
