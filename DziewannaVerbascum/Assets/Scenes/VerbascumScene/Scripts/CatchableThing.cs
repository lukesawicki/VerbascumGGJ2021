using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchableThing : MonoBehaviour
{
    public Transform grabPlace;

    void OnMouseDown()
    {
        GetComponent<Rigidbody>().useGravity = false;
        GetComponent<Rigidbody>().freezeRotation = true;
        //GetComponent<Rigidbody>().isKinematic = true;
        this.transform.position = grabPlace.position;
        this.transform.parent = GameObject.Find("Hand").transform;
    }

    void OnMouseUp()
    {
        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<Rigidbody>().freezeRotation = false;
        //GetComponent<Rigidbody>().isKinematic = false;
    }

}
