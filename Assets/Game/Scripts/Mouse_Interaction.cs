using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class Mouse_Interaction : MonoBehaviour
{
    Vector3 offset;
    GameObject selectedObject;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        
        var ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit) && hit.rigidbody){
            hit.rigidbody.AddForceAtPosition(new Vector3(0, 0, 0), hit.point,ForceMode.Impulse);
        }
        
        // if (Physics.Raycast(ray, out hit) && hit.rigidbody && Input.GetMouseButton(0))
        // {
    
        //     //hit.rigidbody.AddForce(new Vector3(0, 2, 0), ForceMode.Impulse);
        //     //hit.rigidbody.AddForceAtPosition(new Vector3(0, 30, 0), hit.point, ForceMode.Impulse);
        // }
    }

    

    
}
