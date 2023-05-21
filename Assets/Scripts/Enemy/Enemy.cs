using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Header("Prefabs")]
    [SerializeField] ParticleSystem explodePrefab;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        ParticleSystem ps = Instantiate(explodePrefab, transform.position, Quaternion.identity);
        ps.Play();
        Destroy(gameObject);
    }

}
