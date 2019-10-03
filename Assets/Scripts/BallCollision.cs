using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other) {
        float x,y,z;
        x = transform.localScale.x;
        y = transform.localScale.y;
        z = transform.localScale.z;
        transform.localScale -= new Vector3(0.5f * x, 0.5f * y, 0.5f * z);
    }
}
