using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Header("Prefabs")]
    [SerializeField] ParticleSystem explodePrefab;

    protected void DeployParticles()
    {
        ParticleSystem ps = Instantiate(explodePrefab, transform.position, Quaternion.identity);
        ps.Play();
        Destroy(gameObject);
    }

}
