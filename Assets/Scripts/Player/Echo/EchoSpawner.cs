using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EchoSpawner : MonoBehaviour
{
    [Header("Prefabs")]
    [SerializeField] Echo echoPrefab;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(echoPrefab, transform.position, Quaternion.identity);
        }
        
    }
}
