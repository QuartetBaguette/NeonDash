using Unity.VisualScripting;
using UnityEngine;

public class LevelFinish : MonoBehaviour
{
    private PlayerMovement playerMovement;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {   
            collision.GetComponent<PlayerMovement>().enabled = false;
            Time.timeScale = 0;
        }
    }
}
 