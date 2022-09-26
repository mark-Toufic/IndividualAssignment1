using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour
{
    public PlayerHealth playerHealth;
    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Player")
        {
            playerHealth.health += 10;
            Destroy(gameObject);
        }
    }
}
