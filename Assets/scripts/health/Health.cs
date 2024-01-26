using UnityEngine;

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
            GetComponent<Rigidbody2D>().simulated = false;
            if(!anim.GetBool("grounded")) {
                anim.SetBool("grounded", true);
                anim.Play("die");
            }
            dead = true;
        }
    }

    public void AddHealth(float _value)
    {
        currentHealth = Mathf.Clamp(currentHealth + _value, 0, startingHealth);
    }

    public void Respawn()
    {
        dead = false;
        AddHealth(startingHealth);
        anim.ResetTrigger("die");
        anim.Play("idle");
        GetComponent<PlayerMovement>().enabled = true;
        GetComponent<Rigidbody2D>().simulated = true;
    }
}
