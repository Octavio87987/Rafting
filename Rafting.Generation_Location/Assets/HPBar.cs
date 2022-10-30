using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HPBar : MonoBehaviour
{
    [SerializeField] float _hp;
    float _maxHP = 100;

    [SerializeField] Image _bar;
    [SerializeField] TextMeshProUGUI _text;

    void Start()
    {
        _hp = _maxHP;
    }

    public void ReduceHP(float damage)
    {
        _hp -= damage;

        _bar.rectTransform.localScale = new Vector3(1, (int)_hp / _maxHP, 1);
        _text.text = $"{_hp:0.} / {_maxHP}";
    }
}