using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMovement : MonoBehaviour
{
    // Speed of the target's horizontal movement
    float speed = 0.01f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Get the current position of the target
        Vector2 pos = transform.position;
        pos.x += speed;

        // Converting the target position from world space to screen space.
        Vector2 squareInScreenSpace = Camera.main.WorldToScreenPoint(pos);
        
        // Checking if the target is moving beyond the edges of the screen
        if (squareInScreenSpace.x < -10 || squareInScreenSpace.x > Screen.width)
        {
            speed = speed * -1;
        }

        transform.position = pos;
    }
}

