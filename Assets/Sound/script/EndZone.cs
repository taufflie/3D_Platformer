using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndZone : MonoBehaviour
{
    private GameObject End;
    private void OnTriggerEnter(Collider other)
    {
        End = GameObject.Find("UI END");
        End.GetComponent<Canvas>().enabled = false;
        if (other.CompareTag("Player"))
        {
            End.GetComponent<Canvas>().enabled = true;
        }
    }
}