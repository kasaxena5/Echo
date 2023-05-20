using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EchoBeam : MonoBehaviour
{
    [Header("Configs")]
    [SerializeField] private float echoBeamSpeed;

    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * echoBeamSpeed);
        
    }
}
