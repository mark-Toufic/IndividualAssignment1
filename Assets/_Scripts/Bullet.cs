using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bullet : MonoBehaviour
{

    public int damage;

    private void OnCollisionEnter(Collision other) {
        Destroy(gameObject);

        if(other.collider.tag == "Player")
        {
            
                Vector3 dmgDirection = other.transform.position - transform.position;
                dmgDirection = dmgDirection.normalized;

                FindObjectOfType<PlayerHealth>().DamagePlayer(damage, dmgDirection);
            

        } 
        else if(other.collider.tag == "Enemy")
        {
            Vector3 dmgDirection = other.transform.position - transform.position;
            dmgDirection = dmgDirection.normalized;

            FindObjectOfType<EnemyHealth>().DamageEnemy(damage, dmgDirection);


        }
    }
}
