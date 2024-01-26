using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    [SerializeField] public Transform respawnPoint; //Store last checkpoint
    [SerializeField] public Transform respawnCamera; //Store last checkpoint
    private Health playerHealth;

    private void Awake()
    {
        playerHealth = GetComponent<Health>();
    }

    public void RespawnPlayer()
    {
        playerHealth.Respawn();// restore health and animation

        Camera.main.GetComponent<CameraController>().MoveToNewRoom(respawnCamera.parent);
        transform.position = respawnPoint.position; // Move player to last checkpoint
    }
}
