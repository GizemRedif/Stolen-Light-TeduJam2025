using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float maxHealth;
    private float health;
    void Start()
    {
        health = maxHealth;
    }

    
    void Update()
    {
        
    }

    public void TakeDamage(float damage){
        if(health-damage > 0){
            health -= damage;
        }
        else{
            health = 0;
            Die();
        }
        Debug.Log("Can: "+health);
    }
    void Die(){

        Destroy(gameObject);
    }
    public float GetHealth(){return health;}
    public void SetHealth(float health){this.health = health;}
    public float GetMaxHealth(){return maxHealth;}
}
