using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class Enemy : MonoBehaviour, IDamageable
{
    public int maxHealth;
    private int currentHealth;

    protected Animator anim;
    protected Rigidbody rigid;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    public void Damage(int Damage)
    {
        currentHealth -= Damage;

        if(currentHealth <= 0)
        {
            this.gameObject.SetActive(false);
        }
    }
}
