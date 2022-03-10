using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube_collider : MonoBehaviour
{

    SpringJoint[] joints;
    // Start is called before the first frame update
    GameObject[] cubes;

    public Boolean isCollided;
    Color c;

    int springForce;
    void Start()
    {
        isCollided = false;

        joints = GameObject.FindObjectsOfType<SpringJoint>();
        cubes = GameObject.FindGameObjectsWithTag("Cube");
        c = Color.red;
        springForce = 0;
    }

    void OnCollisionEnter(Collision collision)
    {
        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "Cube")
        {

            if (isCollided){
                c = Color.white;
                springForce = 10;
            }
            else{
                c = Color.red;
                springForce = 0;
            }

            foreach(SpringJoint joint in joints){
               joint.spring = springForce;
            }

            
            // collision.gameObject.GetComponent<Renderer>().material.SetColor("_Color", c);
            // this.gameObject.GetComponent<Renderer>().material.SetColor("_Color", c);
            foreach(GameObject cube in cubes){
                cube.GetComponent<Renderer>().material.SetColor("_Color", c);

                if(isCollided){
                    cube.GetComponent<cube_collider>().isCollided = false;
                }
                else{
                    cube.GetComponent<cube_collider>().isCollided = true;
                }
            }
        }
    }
}
