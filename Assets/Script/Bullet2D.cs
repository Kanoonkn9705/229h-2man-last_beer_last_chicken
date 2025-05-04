using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet2D : MonoBehaviour
{
    public float damage = 10f;

    void OnTriggerEnter2D(Collider2D collision)
    {
        // ตรวจสอบว่าโดนศัตรูหรือไม่
        Enemy enemy = collision.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
            Destroy(gameObject); // ทำลายกระสุนหลังโดน
        }
    }
}
