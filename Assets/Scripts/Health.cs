using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [Header("Health value")]
    public float maxHealth;
    [HideInInspector] public float currentHealth;

    [Header("For health bar canvas object")]
    public Slider healthBar;

    [Header("Health value adjustments for hits and misses")]
    public float healthToAdd;
    public float healthToDeduct;


    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if(currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
    }

    public void AddHealth()
    {
        currentHealth += healthToAdd;
        healthBar.value = currentHealth;
    }
    
    public void DeductHealth()
    {
        currentHealth -= healthToDeduct;
        healthBar.value = currentHealth;
    }
}
