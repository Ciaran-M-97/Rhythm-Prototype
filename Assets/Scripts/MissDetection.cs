using UnityEngine;

public class MissDetection : MonoBehaviour
{
    [HideInInspector] public GameObject health;

    void Start()
    {
        health = GameObject.FindGameObjectWithTag("Health Tracker");
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        health.GetComponent<Health>().DeductHealth();
    }
}
