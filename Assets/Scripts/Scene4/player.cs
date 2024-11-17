using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player4 : MonoBehaviour
{
    Rigidbody rb;

    float xInput;
    float zInput;

    public float moveSpeed;

    public AudioClip coinCollectSound;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        float xVelocity = xInput * moveSpeed;
        float zVelocity = zInput * moveSpeed;

        rb.velocity = new Vector3(xVelocity, rb.velocity.y, zVelocity);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Coin")
        {
            Destroy(collision.gameObject);

            //Play soundclip when coin is collected (this only allows one soundclip per object)
            //GetComponent<AudioSource>().Play();

            //Add multiple sound clips by initialising clip at the start
            GetComponent<AudioSource>().PlayOneShot(coinCollectSound);
        }
    }
}
