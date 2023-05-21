using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockEnemy : Enemy
{
    [Header("Configs")]
    [SerializeField] private float damage;

    private Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Initialize(float initialSpeed, float size)
    {
        rb.velocity = new Vector2(0, initialSpeed);
        this.transform.localScale = new Vector3(size, size, size);
    }
}
