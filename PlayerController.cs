    using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public int speed;

    private Rigidbody rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Get input for each axis;
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moverVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moverVertical);
        rb.AddForce(movement * speed);
    }
}

