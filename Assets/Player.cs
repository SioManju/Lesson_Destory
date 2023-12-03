using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    Rigidbody PlayerRb;

    void Start()
    {
        PlayerRb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            PlayerRb.AddForce(Vector3.right);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            PlayerRb.AddForce(Vector3.left);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            PlayerRb.AddForce(Vector3.forward);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            PlayerRb.AddForce(Vector3.back);
        }

    }
}
