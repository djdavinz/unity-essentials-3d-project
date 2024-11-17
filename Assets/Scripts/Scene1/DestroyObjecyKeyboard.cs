using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjecyKeyboard : MonoBehaviour
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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Destroy(gameObject);

            rb.AddForce(Vector3.up * 500);
        }
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
