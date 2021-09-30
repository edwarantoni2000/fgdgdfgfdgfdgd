
using UnityEngine;

public class Boost : MonoBehaviour
{
    GameObject player;
    GameObject a;
    PlayerMovement playermove;

    private void Awake()
    {
        a = GameObject.FindGameObjectWithTag("Boost");
        player = GameObject.FindGameObjectWithTag("Player");
        playermove = player.GetComponent<PlayerMovement>();
    }
    void OnTriggerEnter(Collider other)
    {
        //Set player in range
        if (other.gameObject == player && other.isTrigger == false)
        {
            playermove.speede(5f);
            Destroy(a);
        }
    }
}
