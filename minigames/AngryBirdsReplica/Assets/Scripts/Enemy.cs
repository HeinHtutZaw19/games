using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float health = 2f;
    public GameObject deathEffect;
    public static int EnemiesAlive = 0;
    // Start is called before the first frame update
    void Start()
    {
        EnemiesAlive++;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.magnitude > health)
        {
            Instantiate(deathEffect, transform.position, Quaternion.identity);

            Destroy(gameObject);
            EnemiesAlive--;
            if (EnemiesAlive == 0)
            {
                Debug.Log("LevelWon");
            }
        }
    }
}
