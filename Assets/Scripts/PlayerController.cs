using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float forwardInput;
    public float turnSpeed = 45f;
    float horizontalInput;
    public float speed = 20f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // Move the vehical forwards
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);    
        transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * horizontalInput);
    }
}
