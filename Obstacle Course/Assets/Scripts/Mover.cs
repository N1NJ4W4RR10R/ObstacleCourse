using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 7;

// Start is called before the first frame update
    void Start() {
        PrintInstruction();
    }

    // Update is called once per frame
    void Update() {
        MovePlayer();
    }

    void PrintInstruction() {
        Debug.Log("Hello Game");
        Debug.Log("Please move the character");
        Debug.Log("This confirms movement is working");
    }

    void MovePlayer() {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        
        transform.Translate(xValue, 0, zValue);
    }

}
