using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    

    // Update is called once per frame. Not using forces so dont use fixupdate.
    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime); //The last part makes it smooth and framerate independent.
    }
}
