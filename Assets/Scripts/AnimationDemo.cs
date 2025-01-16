using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationDemo : MonoBehaviour
{
    public AnimationCurve curve;

    [Range(0,1)]
    public float T;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        T += Time.deltaTime;

        if(T > 1)
        {
            T = 0;
        }

        transform.localScale = Vector2.one * curve.Evaluate(T);
    }
}
