using UnityEngine;
using UnityEngine.UI;

public class Gravity : MonoBehaviour
{
    public GameObject player;
    private Rigidbody rb;
    private void Start()
    {
        rb.useGravity = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            rb.useGravity = true;
        }
    }
}
