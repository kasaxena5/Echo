using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EchoSpawner : MonoBehaviour
{
    [Header("Prefabs")]
    [SerializeField] Transform target;
    [SerializeField] Echo echoPrefab;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Vector3 direction = (target.position - transform.position).normalized;
            Instantiate(echoPrefab, transform.position, Quaternion.identity);
        }
        
    }
}
