using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Private Variables
    private float speed = 50.0f;
    private float turnspeed = 70.f;
    private float horizontalInput; 
    private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
      
        // move vehicle forward 
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // vehicle turns
        transform.Rotate(Vector3.up, turnspeed * horizontalInput * Time.deltaTime);

    }
}
