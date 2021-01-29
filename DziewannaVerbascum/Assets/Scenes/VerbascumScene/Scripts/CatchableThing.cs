using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchableThing : MonoBehaviour
{
    public Transform grabPlace;
    [SerializeField] private string pickableTag = "Pickable";
    public HerbsManager herbsManager;


    void OnMouseDown()
    {
        if (!gameObject.CompareTag(pickableTag))
        {
            Debug.Log("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
            GetComponent<Rigidbody>().useGravity = false;
            GetComponent<Rigidbody>().freezeRotation = true;
            //GetComponent<Rigidbody>().isKinematic = true;
            this.transform.position = grabPlace.position;
            this.transform.parent = GameObject.Find("Hand").transform;
        }
        if (gameObject.CompareTag(pickableTag))
        {
            herbsManager.addHerb(gameObject);
            Destroy(gameObject);
        }

    }

    void OnMouseUp()
    {
        if (!gameObject.CompareTag(pickableTag))
        {
            this.transform.parent = null;
            GetComponent<Rigidbody>().useGravity = true;
            GetComponent<Rigidbody>().freezeRotation = false;
            //GetComponent<Rigidbody>().isKinematic = false;
        }
    }

}
