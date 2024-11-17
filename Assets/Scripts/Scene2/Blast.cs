using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blast : MonoBehaviour
{
    public GameObject blastEffect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        //spawn blast particle

        Vector3 spawnPosition = new Vector3(transform.position.x, 1.05f, transform.position.z);
        Instantiate(blastEffect, transform.position, blastEffect.transform.rotation);
        Destroy(gameObject);
    }
}
