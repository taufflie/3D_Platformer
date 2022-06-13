using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ZonePoles : MonoBehaviour
{

    public GameObject Player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Player)
        {
            Player.transform.position = new Vector3(232, 5, -170);
        }
        else
        {
            Destroy(other.gameObject);
        }
    }
}

