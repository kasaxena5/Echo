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


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Ground" || collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "Echo")
        {
            DeployParticles();
            if (collision.gameObject.TryGetComponent(out PlayerController player))
            {
                player.InflictDamage(damage);
            }
        }
    }
}
