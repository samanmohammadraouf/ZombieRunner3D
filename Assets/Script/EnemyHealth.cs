using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    [SerializeField] float health = 60f;
   
    public void TakeDamage(float damage)
    {
        BroadcastMessage("TakedDamage");
        health = health - damage;
        if(health <= 0f)
        {
            //Debug.Log(health.ToString());
            Destroy(gameObject);
        }
    }
}
