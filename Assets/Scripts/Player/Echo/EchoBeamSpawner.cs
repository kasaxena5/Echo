using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EchoBeamSpawner : MonoBehaviour
{
    [Header("Prefabs")]
    [SerializeField] EchoBeam echoBeamPrefab;
    [SerializeField] FloatReference mana;
    [SerializeField] float manaUsed;

    [Header("Player Configs")]
    [SerializeField] private float duration;
    [SerializeField] private float targetLength;

    EchoBeam echoBeam;
    [Header("Internal Configs")]
    public bool spawnCompleted = false;
    
    public void InstantiateBeam()
    {
        spawnCompleted = false;
        if (mana.value >= manaUsed)
        {
            mana.value -= manaUsed;
            echoBeam = Instantiate(echoBeamPrefab, transform.position, Quaternion.identity);
            StartCoroutine(GrowEchoBeam(targetLength));
        } else
        {
            spawnCompleted = true;
        }
    }


    IEnumerator GrowEchoBeam(float targetValue)
    {
        float startValue = 0;
        float value;
        float time = 0;
        Reset();

        while (time < duration)
        {
            value = Mathf.Lerp(startValue, targetValue, time / duration);
            Resize(value);
            time += Time.deltaTime;
            yield return null;
        }
        _ = targetValue;
        spawnCompleted = true;
    }

    public void Reset()
    {
        echoBeam.transform.position = transform.position; 
        echoBeam.transform.localScale = new Vector3(0, echoBeam.transform.localScale.y, 0); 
    }

    public void Resize(float value)
    {
        Vector3 position = echoBeam.transform.position;
        position.x = transform.position.x + value / 2;

        echoBeam.transform.position = position;

        Vector3 scale = echoBeam.transform.localScale;
        scale.x = value;

        echoBeam.transform.localScale = scale;
    }
}
