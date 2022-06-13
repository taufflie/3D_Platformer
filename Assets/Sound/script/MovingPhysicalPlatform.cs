using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class MovingPhysicalPlatform : MonoBehaviour
{
    public Vector3 rbAddforce;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Assert.IsNotNull(rb);
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        rb.velocity += rbAddforce;
    }
}
