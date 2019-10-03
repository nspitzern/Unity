using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atmosphere : MonoBehaviour
{
    bool reached;
    // Start is called before the first frame update
    void Start()
    {
        reached = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (reached)
        {
            Debug.Log("OUTA HERE!");
            reached = false;
        }
    }

    void OnTriggerEnter(Collider other) {
        reached = true;
    }
}
