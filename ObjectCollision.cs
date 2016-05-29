using UnityEngine;
using System.Collections;

public class ObjectCollision : MonoBehaviour {

    public int speed;

    void OnCollisionEnter(Collision col)
    {

        //function call for functional abjects

        switch (col.gameObject.name)
        {
            case "Speed_Cube": //Increases playerObject speed
                Destroy(col.gameObject);
                speed = 20;
                break;

            case "Dec_Speed_Cube": //Decreases playerObject speed
                Destroy(col.gameObject);
                speed -= 5;
                break;

            case "Scale_Inc": //Icreases playerObject transform Scale property
                transform.localScale += new Vector3(.2f, .2f, .2f);
                break;

            case "Scale_Dec": // Decreases playerObject transform Scale property
                transform.localScale -= new Vector3(.2f, .2f, .2f);
                break;

            case "PlayerMultiplier": // adds another playerObject 
                GameObject childPlayer;
                childPlayer = new GameObject("player"); // New player initialization 
                childPlayer.AddComponent<Rigidbody>(); // Add Rigidbody Component
                childPlayer.AddComponent<BoxCollider>();//Add BoxCollider Component
                break;

            default:

                break;
        }
    }
}
