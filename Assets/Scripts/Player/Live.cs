
using UnityEngine;

public class Live : MonoBehaviour
{
    GameObject player;
    GameObject a;
    PlayerHealth playerHealth;

    private void Awake()
    {
        a = GameObject.FindGameObjectWithTag("Live");
        player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = player.GetComponent<PlayerHealth>();
    }
    void OnTriggerEnter(Collider other)
    {
        //Set player in range
        if (other.gameObject == player && other.isTrigger == false)
        {
            playerHealth.Live();
            Destroy(a);
        }
    }
}
