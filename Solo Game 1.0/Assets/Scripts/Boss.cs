using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boss : MonoBehaviour
{

    public float maxHealth = 100f;
    public float currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth <= 0f)
        {
            Die();
        }





    }

    public void TakeDamage(float amount)
    { 
        currentHealth -= amount; 
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
