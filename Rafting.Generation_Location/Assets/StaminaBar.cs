using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StaminaBar : MonoBehaviour
{
    [SerializeField] float _stamina;
    float _maxStamina = 100;
    float _staminaCost = 10;
    [SerializeField] float _staminaRegen;

    [SerializeField] Image _bar;
    [SerializeField] TextMeshProUGUI _text;

    void Start()
    {
        _stamina = _maxStamina;
    }

    void Update()
    {
        if (_stamina < _maxStamina)
        {
            _stamina = Mathf.Clamp(_stamina + _staminaRegen * Time.deltaTime, 0, _maxStamina);

            _bar.rectTransform.localScale = new Vector3(1, (int)_stamina / _maxStamina, 1);
            _text.text = $"{_stamina:0.} / {_maxStamina}";
        }
    }

    public bool Enough()
    {
        if (_stamina < _staminaCost) return false;

        _stamina -= _staminaCost;

        return true;
    }
}