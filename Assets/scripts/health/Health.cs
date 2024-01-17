using UnityEngine;
using UnityEngine.Scripting;

public class Health : MonoBehaviour
{
    [SerializeField] private float startingHealth;
    public float currentHealth { get; private set;}
    private Animator anim;
    private bool dead;

    private void Awake() {
        currentHealth = startingHealth;
        anim = GetComponent<Animator>();
    }

    public void TakeDamage(float _damage) {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);
        
        if(!dead) {
            anim.SetTrigger("die");
            GetComponent<PlayerMovement>().enabled = false;
            dead = true;
        }
    }
}
