using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    [SerializeField] FloatReference health;
    
    Slider healthBar;

    void Start()
    {
        healthBar = GetComponent<Slider>();
        healthBar.maxValue = 1;
        healthBar.value = 1;
        health.value = 1;
    }

    void Update()
    {
        healthBar.value = health.value;
    }
}
