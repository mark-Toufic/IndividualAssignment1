using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int maxHealth;
    public int health;

    public EnemyController theEnemy;

    void Start()
    {
        health = maxHealth;

        theEnemy = FindObjectOfType<EnemyController>();

    }


    public void DamageEnemy(int damage, Vector3 direction)
    {
        health -= damage;

        if(health == 0)
        {
            Destroy(gameObject);
        }
    }

}
