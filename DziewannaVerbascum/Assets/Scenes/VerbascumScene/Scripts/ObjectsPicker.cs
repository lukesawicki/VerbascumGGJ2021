using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsPicker : MonoBehaviour
{
    [SerializeField] private Material highlightedMaterial;
    [SerializeField] private Material originalMaterial;
    [SerializeField] private string pickableTag = "Pickable";
    

    private Transform selectedObject;
    Transform selectedObjectTransform = null;

    void Update()
    {

        //if (selectedObject != null)
        //{
        //    Renderer renderer = selectedObject.GetComponent<Renderer>();
        //    renderer.material = originalMaterial;
        //    selectedObject = null;
        //}

        //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //RaycastHit raycastHit;
        //if (Physics.Raycast(ray, out raycastHit))
        //{
        //    //Transform selectedObjectTransform = raycastHit.transform;
        //    selectedObjectTransform = raycastHit.transform;

        //    if (selectedObjectTransform.CompareTag(pickableTag))
        //    {
        //        Renderer selectedObjectRenderer = selectedObjectTransform.GetComponent<Renderer>();
        //        originalMaterial = selectedObjectRenderer.material;
        //        if (selectedObjectRenderer != null)
        //        {
        //            selectedObjectRenderer.material = highlightedMaterial;
        //        }

        //        selectedObject = selectedObjectTransform;
        //    }
        //    else
        //    {
        //        selectedObjectTransform = null;
        //    }
        //}
    }


}