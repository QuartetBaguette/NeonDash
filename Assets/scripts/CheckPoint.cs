using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    [SerializeField] public Transform respawnPoint;
    [SerializeField] public Transform respawnCamera;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {   
            collision.GetComponent<PlayerRespawn>().respawnCamera.SetParent(respawnCamera);
            collision.GetComponent<PlayerRespawn>().respawnPoint = respawnPoint;
        }
    }
}
