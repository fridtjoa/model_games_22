using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class joint_controller : MonoBehaviour

{
    Rigidbody[] allBodys; 
    SpringJoint[] joints;
    // Start is called before the first frame update
    void Start()
    {
      joints = GameObject.FindObjectsOfType<SpringJoint>();   
      allBodys = GameObject.FindObjectsOfType<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w")){
            foreach(SpringJoint joint in joints){
                joint.spring += 2;
            }
        }

        if (Input.GetKeyDown("s")){
            foreach(SpringJoint joint in joints){
                joint.spring -= 2;
            }
        }

        if (Input.GetKeyDown("space")){
            foreach(Rigidbody body in allBodys){
                body.constraints = RigidbodyConstraints.FreezeAll;
            }
        }

        if (Input.GetKeyUp("space")){
            foreach(Rigidbody body in allBodys){
                body.constraints = ~RigidbodyConstraints.FreezeAll;
                body.gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            }
        }

    }

}
