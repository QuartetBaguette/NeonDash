using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    [SerializeField] private Transform respawnPoint; //Store last checkpoint
    [SerializeField] private Transform respawnCamera; //Store last checkpoint
    private Health playerHealth;

    private void Awake()
    {
        playerHealth = GetComponent<Health>();
    }

    public void RespawnPlayer()
    {
        transform.position = respawnPoint.position; // Move player to last checkpoint
        playerHealth.Respawn();// restore health and animation

        Camera.main.GetComponent<CameraController>().MoveToNewRoom(respawnCamera.parent);
    }
}
