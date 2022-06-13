using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadZone : MonoBehaviour{

    public GameObject Player;

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject == Player)
        {
            SceneManager.LoadScene("Platformer");
        }
        else
        {
            Destroy(other.gameObject);
        }
    }
}

