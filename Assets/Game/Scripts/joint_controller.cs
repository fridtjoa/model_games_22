using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class joint_controller : MonoBehaviour

{
    public GameObject gameObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w")){
            gameObject.GetComponentInChildren<SpringJoint>().spring += 1;
        }

        if (Input.GetKeyDown("s")){
            gameObject.GetComponentInChildren<SpringJoint>().spring -= 1;
        }

        if (Input.GetKeyDown("space")){
        }
    }
}
