using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTranform : MonoBehaviour
{
    public GameObject elCubo;
    public Vector3 mewScale;

    // Start is called before the first frame update
    void Start()
    {
        elCubo.transform.localScale = mewScale;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
