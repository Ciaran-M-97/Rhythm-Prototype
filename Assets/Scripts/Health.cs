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

    public GameObject spike;
    Vector3 spikeNewPos;
    public float speed;
    public float maxX;
    public float minX;
    float newX;


    void Start()
    {
        currentHealth = maxHealth/2;
        newX = minX + (maxX - minX) * (currentHealth / maxHealth);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        spikeNewPos = new Vector3(newX, spike.transform.position.y, spike.transform.position.z);
        spike.transform.position = Vector3.MoveTowards(spike.transform.position, spikeNewPos, speed * Time.deltaTime);
        
    }

    public void AddHealth()
    {
        currentHealth += healthToAdd;

        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }

        healthBar.value = currentHealth;
        newX = minX + (maxX - minX) * (currentHealth / maxHealth);
        print(newX);
        print(currentHealth);
        
    }
    
    public void DeductHealth()
    {
        currentHealth -= healthToDeduct;

        if (currentHealth < 0)
        {
            currentHealth = 0;
        }

        healthBar.value = currentHealth;
        newX = minX + (maxX - minX) * (currentHealth / maxHealth);
        print(newX);
        print(currentHealth);
    }
}
