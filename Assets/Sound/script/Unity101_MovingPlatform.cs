using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unity101_MovingPlatform : MonoBehaviour
{
    public GameObject Player;
    public GameObject platform;
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject == Player)
        {
            other.transform.parent = platform.transform;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == Player)
        {
            other.transform.parent = null;
        }
    }
}
