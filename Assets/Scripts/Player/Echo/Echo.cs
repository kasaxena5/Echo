using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Echo : MonoBehaviour
{
    [SerializeField] float speed;

    void Update()
    {
        transform.Translate(speed * Time.deltaTime * Vector3.right);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(this.gameObject);
    }
}
