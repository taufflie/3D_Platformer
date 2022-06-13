using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToZone3 : MonoBehaviour
{

    public GameObject Player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Player)
        {
            Player.transform.position = new Vector3(-230, 5, 230);
        }
        else
        {
            Destroy(other.gameObject);
        }
    }
}

