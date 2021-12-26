using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float health = 161f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(float damage)
    {
        health -= damage;
        if(health <= 0)
        {
            GameOverHandler gameOver = GetComponent<GameOverHandler>();
            if(gameOver != null)
            {
                gameOver.HandlerDeath();
            }
            //Destroy(gameObject);
        }
    }
}
