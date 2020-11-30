using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform enemy; 
    
    public float maxBoundary, minBoundary;
    
    private float velocityEnemy = 0;
    private float amplitude = 1;
    
    // Start is called before the first frame update
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        velocityEnemy = Input.GetAxis("EnemyInput");
        
        // Deals with movement within a boundary
        // TODO: need to figure out boundarys when the player moves
        if (enemy.position.x < minBoundary && velocityEnemy < 0)
        {
            velocityEnemy = 0;
        } else if (enemy.position.x > maxBoundary && velocityEnemy > 0)
        {
            velocityEnemy = 0;
        }
        enemy.position += (Vector3.right * velocityEnemy * amplitude) / 10;
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("We hit the player!");
            // We need it to throw a punch. 
        }
    }
}
