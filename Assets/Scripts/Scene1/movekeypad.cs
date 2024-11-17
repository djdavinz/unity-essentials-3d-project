using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movekeypad : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //move forward
        if (Input.GetKeyDown(KeyCode.W))
        {
          rb.velocity = Vector3.forward * 2f;
        }
        //move backward
        if (Input.GetKeyDown(KeyCode.S))
        {
            rb.velocity = Vector3.back * 2f;
        }
        //move left
        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.velocity = Vector3.left * 2f;
        }
        //move right
        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.velocity = Vector3.right * 2f;
        }


    }

}
