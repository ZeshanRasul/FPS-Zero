using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health = 50f;

    bool isDead = false;

    public GameObject enemyGFX;

    public void TakeDamage(float amount)
    {
        health -= amount;

        if (health <= 0f && isDead == false)
        {
            isDead = true;
            Die();
        }
    }

    void Die()
    {
        enemyGFX.GetComponent<Animator>().SetTrigger("Die");
    }
}
