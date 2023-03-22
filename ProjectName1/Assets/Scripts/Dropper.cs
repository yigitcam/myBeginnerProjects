using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody rb;

    [SerializeField]float passedTime = 10f;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rb = GetComponent<Rigidbody>();

        rb.useGravity = false;
        renderer.enabled = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > passedTime)
        {
            rb.useGravity = true;
            renderer.enabled = true;
        }
    }
}
