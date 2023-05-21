using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatEnemy : Enemy
{

    [Header("Configs")]
    [SerializeField] float speed;
    [SerializeField] float damage;

    Transform target;
    Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Initialize(Vector2 direction, float speed, Transform target)
    {
        rb.velocity = direction.normalized * speed;
        this.speed = speed;
        this.target = target;
    }

    void Update()
    {
        Vector2 seekDirection = (target.position - transform.position).normalized * speed;
        Vector2 steerDirection = seekDirection - rb.velocity;
        rb.AddForce(steerDirection);
    }
}
