using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset; // offset is private to set value in the script
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position; //difference between current position of camera and the player
    }

    // Update is called once per frame
    void LateUpdate() // runs every frame, also runs all items processed in update (following cameras, getting last know states)
    {
        transform.position = player.transform.position + offset; //camera is moved to new position before displaying to what camera can see
    }
}
