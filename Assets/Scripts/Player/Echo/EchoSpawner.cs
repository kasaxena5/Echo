using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EchoSpawner : MonoBehaviour
{
    [Header("Prefabs")]
    [SerializeField] Echo echoPrefab;
    [SerializeField] FloatReference mana;
    [SerializeField] float manaUsed;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (mana.value >= manaUsed)
            {
                mana.value -= manaUsed;
                Instantiate(echoPrefab, transform.position, Quaternion.identity);
            }
        }
        
    }
}
