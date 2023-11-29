using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int currentEnemyHealth;
    public int maxEnemyHealth;
    public float enemySpeed;
    public float enemyDamage;

    public HealthBar healthBar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Projectile"))
        {
            TakeDamage(20);
        }
    }
    public void TakeDamage(int damage)
    {
        currentEnemyHealth -= damage;
        healthBar.SetHealth(currentEnemyHealth);
    }
}
