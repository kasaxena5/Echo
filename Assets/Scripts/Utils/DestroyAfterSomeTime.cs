using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterSomeTime : MonoBehaviour
{
    [SerializeField] float duration;

    void Start()
    {
        Destroy(gameObject, duration);
    }
}
