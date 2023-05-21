using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Echo : MonoBehaviour
{
    [SerializeField] float speed;
    float direction;

    void Update()
    {
        transform.Translate(speed * Time.deltaTime * Vector3.right * direction);
    }
    public void Initialize(float facingRight)
    {
        direction = facingRight;
        if (facingRight < 0)
            this.transform.localScale *= -1;
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag != "Player")
            Destroy(this.gameObject);
    }
}
