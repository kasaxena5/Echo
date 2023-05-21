using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EchoBeam : MonoBehaviour
{
    [Header("Configs")]
    [SerializeField] private float echoBeamSpeed;
    float direction;

    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * echoBeamSpeed * direction);
    }

    public void Initialize(float facingRight)
    {
        direction = facingRight;
        if (facingRight < 0)
        {
            this.GetComponent<SpriteRenderer>().flipX = true;
        }

    }
}
