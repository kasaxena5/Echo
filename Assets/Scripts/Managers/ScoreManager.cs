using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] IntReference score;
    [SerializeField] float scoreWaitTime = 3;
    TMP_Text scoreText;

    void Start()
    {
        scoreText = GetComponent<TMP_Text>();
        score.value = 0;
        scoreText.text = "Score: " + score.value;
        StartCoroutine(IncrementScore());
    }

    void Update()
    {
        scoreText.text = "Score: " + score.value;
    }

    IEnumerator IncrementScore()
    {
        while(true)
        {
            yield return new WaitForSeconds(scoreWaitTime);
            score.value += 1;
        }
    }
}
