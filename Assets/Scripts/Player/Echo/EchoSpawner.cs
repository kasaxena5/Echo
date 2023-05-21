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
        if (Input.GetKeyDown(KeyCode.J))
        {
            if (mana.value >= manaUsed)
            {
                mana.value -= manaUsed;
                Echo echo = Instantiate(echoPrefab, transform.position, Quaternion.identity);
                echo.Initialize(PlayerController.facingRight);
            }
        }
        
    }
}
