using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TrickShot : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 0.1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        pos.x += speed;

        Vector2 squareInScreenSpace = Camera.main.WorldToScreenPoint(pos);
        if (squareInScreenSpace.x < -10 || squareInScreenSpace.x > Screen.width)
        {
            speed = speed * -1;
        }

        transform.position = pos;

        if (Input.GetKeyUp(KeyCode.Space) == true)
        {
            
        }

    }
}


