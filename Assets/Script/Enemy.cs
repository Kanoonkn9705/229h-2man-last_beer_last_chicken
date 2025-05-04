using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float maxHealth = 100f;
    private float currentHealth;

    [SerializeField] private HealthBar healthBar; // ลิงก์ HealthBar

    void Start()
    {
        currentHealth = maxHealth;
        if (healthBar != null)
        {
            healthBar.SetMaxHealth((int)maxHealth); // ตั้งค่า max health
        }
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        currentHealth = Mathf.Max(currentHealth, 0); // ป้องกันเลือดติดลบ

        if (healthBar != null)
        {
            healthBar.SetHealth((int)currentHealth); // อัปเดตแถบเลือด
        }

        if (currentHealth <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);  // หรือทำเอฟเฟกต์ตาย
    }
}
