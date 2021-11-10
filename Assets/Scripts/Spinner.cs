using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{

    public float xAngle = 0;
    public float yAngle = 0;
    public float zAngle = 0;

    // Update is called once per frame
    void Update()
    {
        // Adding deltTime to make this framerate independent
        transform.Rotate(xAngle * Time.deltaTime, yAngle * Time.deltaTime, zAngle * Time.deltaTime);
    }
}
