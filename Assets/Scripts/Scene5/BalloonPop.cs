using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonPop : MonoBehaviour
{
    public int clicksToPop;

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
        clicksToPop -= 1;

        transform.localScale += new Vector3(0.15f, 0.2f, 0.09f);

        //Destroy balloon when clicks reach 0

        if(clicksToPop == 0)
        {
            Destroy(gameObject);
        }

    }
}
