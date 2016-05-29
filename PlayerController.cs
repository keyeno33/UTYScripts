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

    void OnCollisionEnter(Collision col)
    {
        Destroy(col.gameObject);
        //function call for functional abjects

        switch (col.gameObject.name)
        {
            case "Speed_Cube":
                speed = 20;
                break;

            case "Dec_Speed_Cube":
                speed -= 5;
                break;

            case "Scale_Inc":
                transform.localScale += new Vector3(.2f, .2f, .2f);
                break;

            case "Scale_Dec":
                transform.localScale += new Vector3(.2f, .2f, .2f);
                break;

            case "PlayerMultiplier":
                GameObject childPlayer;
                childPlayer = new GameObject("player");
                childPlayer.AddComponent<Rigidbody>();
                childPlayer.AddComponent<BoxCollider>();
                break;

            default:
                return;
                break;
        }

    }
}

