using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class Trappe90 : MonoBehaviour
{
    public GameObject Player;
    private bool Flag;

    private void Start()
    {
        Flag = false;
    }
    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (Flag == false)
        {
            if (other.gameObject == Player)
            {
                transform.eulerAngles = new Vector3(transform.eulerAngles.x + 90, transform.eulerAngles.y, transform.eulerAngles.z);
                Flag = true;
            }
        }
    }
}
