using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 2.0f;
    private Rigidbody enemyRb;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        // get the player's position, get the enemy's position and subtract both. Add a .normalize to ensure the enemy follows the player at the same speed irrespective of distance then add speed to the equation.
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        enemyRb.AddForce( lookDirection * speed);

        // if the enemy falls destroy it
        if(transform.position.y < -10 )
        {
            Destroy(gameObject);
        }
    }
}
