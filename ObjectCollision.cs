using UnityEngine;
using System.Collections;

public class ObjectCollision : MonoBehaviour {

    public int speed;

    void OnCollisionEnter(Collision col)
    {


        switch (col.gameObject.name)
        {
                Destroy(col.gameObject);
                speed = 20;
                break;

                Destroy(col.gameObject);
                speed -= 5;
                break;

                transform.localScale += new Vector3(.2f, .2f, .2f);
                break;

                transform.localScale -= new Vector3(.2f, .2f, .2f);
                break;

                GameObject childPlayer;
                break;

            default:

                break;
        }
    }
}
