using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launch : MonoBehaviour
{
    public ConstantForce cf;
    bool accelerate = false;

    // Start is called before the first frame update
    void Start()
    {
        cf = GetComponent<ConstantForce>();
    }

    // Update is called once per frame
    void Update()
    {
        if(accelerate) {
            cf.force = cf.force + new Vector3(0, 0.1f, 0);
        }
    }

    void OnCollisionEnter(Collision collision) {
        cf.force = new Vector3(0, 10, 0);
        accelerate = true;
    }
}
