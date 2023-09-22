using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    new MeshRenderer renderer;
    Rigidbody rigidBody;
    [SerializeField] float timePassed = 3; 
    
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rigidBody = GetComponent<Rigidbody>();

        renderer.enabled = false;
        rigidBody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > timePassed) {
            renderer.enabled = true;
            rigidBody.useGravity = true;
        }
    }
}
