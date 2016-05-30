using UnityEngine;
using System.Collections;

public class ObjectDestroy : MonoBehaviour {

    void onCollisionEnter(Collision col)
    {
        Destroy(col.gameObject);
    }
}
