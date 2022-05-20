using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectMovement : MonoBehaviour
{
    public GameObject elCubo;
    public Vector3 movementvector;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        elCubo.transform.eulerAngles += movementvector;
    }
}
