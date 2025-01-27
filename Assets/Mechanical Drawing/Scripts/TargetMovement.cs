using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMovement : MonoBehaviour
{
    public float speed = 1f; // Speed of movement
    public float range = 3f; // Range of back and forth motion
    private Vector2 startPosition;
    // Start is called before the first frame update
    void Start()
    {
        // Storing the initial position
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // Using Mathf.PingPong to return a value between 0 and my range no more and no less
        float offset = Mathf.PingPong(Time.time * speed, range);
        transform.position = new Vector2(startPosition.x + offset, startPosition.y);
    }
}
