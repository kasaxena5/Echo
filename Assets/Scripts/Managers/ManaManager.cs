using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaManager : MonoBehaviour
{
    [SerializeField] FloatReference mana;

    Slider manaBar;
    [SerializeField] float manaRefillRate;
    [SerializeField] float manaRefillTime;

    void Start()
    {
        manaBar = GetComponent<Slider>();
        manaBar.maxValue = 1;
        manaBar.value = 1;
        mana.value = 1;
        StartCoroutine(IncreaseMana());
    }

    void Update()
    {
        manaBar.value = mana.value;
    }

    IEnumerator IncreaseMana()
    {
        while (GameManager.Instance.GamePlaying)
        {
            yield return new WaitForSeconds(manaRefillTime);
            mana.value += manaRefillRate;
            mana.value = Mathf.Min(mana.value, 1);
        }
    }
}
