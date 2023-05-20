using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EchoBeamSpawner : MonoBehaviour
{
    [SerializeField] GameObject echoBeamPrefab;
    [SerializeField] private float duration;
    [SerializeField] private float targetLength;

    GameObject echoBeam;

    public bool spawnCompleted = false;
    
    public void InstantiateBeam()
    {
        echoBeam =  Instantiate(echoBeamPrefab, transform.position, Quaternion.identity);
        StartCoroutine(GrowEchoBeam(targetLength));
    }


    IEnumerator GrowEchoBeam(float targetValue)
    {
        float startValue = 0;
        float time = 0;
        while (time < duration)
        {
            _ = Mathf.Lerp(startValue, targetValue, time / duration);
            time += Time.deltaTime;
            yield return null;
        }
        _ = targetValue;
        spawnCompleted = true;
    }

}
