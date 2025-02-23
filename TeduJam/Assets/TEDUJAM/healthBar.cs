using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthBar : MonoBehaviour
{
   public Image backGrounImage;
   public Image healthImage;

   public float maxHealth=100f;
   public float currentHealth;
    public GameObject player;
    
    

    void Start()
    {
        currentHealth=maxHealth;
       
        
    }
    void Update()
    {
        
        currentHealth = player.GetComponent<Health>().GetHealth();
        UpdateHealthBar(); //Oyun başladığında sağlık barı güncelleniyor
    }
    

    public void TakeDamage( float damage)
    {
        currentHealth -=damage;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth); // Sağlık değeri 0 ile maxHealth arasında değer alacak
        UpdateHealthBar();
    }

    void UpdateHealthBar()
    {
        Debug.Log("Player Health: " + (currentHealth / maxHealth)*100); // Sağlığını kontrol amaçlı
        healthImage.fillAmount = currentHealth / maxHealth; 
    }
}
