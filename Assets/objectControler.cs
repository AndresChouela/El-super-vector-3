using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectControler : MonoBehaviour
{
    public Vector3 movementVector;
    public float xSpeed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z < 7)
        {
            transform.position += new Vector3(0,0,xSpeed);
        }
        else
        {
            transform.position += new Vector3(0, -xSpeed, 0);
        }
    }
}
