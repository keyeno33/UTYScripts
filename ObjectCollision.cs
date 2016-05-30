using UnityEngine;
using System.Collections;

public class ObjectCollision : MonoBehaviour {

    private int Speed;

    void OnCollisionEnter(Collision col)
    {

        //function call for functional abjects

        switch (col.gameObject.name)
        {
            case "Cube":
                Destroy(col.gameObject);
                break;

            case "Speed_Cube": //Increases playerObject speed by 5
                Speed += 5;
                Destroy(col.gameObject);
                break;

            case "Dec_Speed_Cube": //Decreases playerObject speed
                Speed -= 5;
                Destroy(col.gameObject);
                break;

            case "Default_Speed":
                Speed = 5;
                Destroy(col.gameObject);
                break;

            case "Scale_Inc": //Icreases playerObject transform Scale property
                transform.localScale += new Vector3(2f, 2f, 2f);
                Destroy(col.gameObject);
                break;

            case "Scale_Dec": // Decreases playerObject transform Scale property
                transform.localScale = new Vector3(.5f, .5f, .5f);
                Destroy(col.gameObject);
                break;

            case "Default_Scale":
                transform.localScale = new Vector3(1f, 1f, 1f);
                Destroy(col.gameObject);
                break;
                 
            case "PlayerMultiplier": // adds another playerObject 
                GameObject childPlayer;
                childPlayer = new GameObject("player"); // New player initialization 
                childPlayer.AddComponent<Rigidbody>(); // Add Rigidbody Component
                childPlayer.AddComponent<BoxCollider>();//Add BoxCollider Component
                Destroy(col.gameObject);
                break;

            default:

                break;
        }
    }
}
