using UnityEngine;
using UnityEngine.UI;

public class Unity101_DissapearOnCollision : MonoBehaviour
{
    public GameObject player;
    Text m_Text;
    int score;
    void Start()
    {
        //Fetch the Text component from the GameObject
        m_Text = GameObject.Find("Score").GetComponent<Text>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //Change the Text to the message below
            score = int.Parse(m_Text.text) + 1;
            m_Text.text = score.ToString();
            Destroy(gameObject);
        }
    }
}

