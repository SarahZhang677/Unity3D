using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed; //can change speed in editor
    private Rigidbody rb;
    private int count; // wont be collecting partial objects. No access to it in inspector because its private.
    public Text countText;
    public Text winText;
     void Start() 
    {
        rb = GetComponent<Rigidbody>(); // gets reference
        count = 0;
        SetCountText();
        winText.text = "";
    } 
     void FixedUpdate() //for items that require physics 
    {
        float moveHorizontal = Input.GetAxis("Horizontal"); // gets input
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical); 
        rb.AddForce(movement*speed); //makes the movement
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up")) { //comparing tag with string value.
            other.gameObject.SetActive(false); //deactivates "pickup" game objects.
            count = count + 1;
            SetCountText();
        }
    }
    void SetCountText() {
        countText.text = "Count: " + count.ToString();
        if(count >= 8)
        {
            winText.text = "You Win!";
        }
    }
}
