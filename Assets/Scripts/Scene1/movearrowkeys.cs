using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movearrowkeys : MonoBehaviour
{
    Rigidbody rb;
    float xInput;
    float zInput;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");

        rb.AddForce(xInput * speed, 0, zInput * speed);
    }
}
