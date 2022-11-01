using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float _power;
    [SerializeField] HPBar _hp;
    [SerializeField] StaminaBar _stamina;

    Rigidbody _rb;

    [SerializeField] float rot;
    [SerializeField] float forvard;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    public void Row(float force, bool rightPadle)
    {
        if (!_stamina.Enough()) return;

        _rb.AddTorque(new Vector3(0, force, 0) * _power * rot * (rightPadle ? -1: 1), ForceMode.Force);
        _rb.AddForce(transform.forward * _power * forvard * (force < 0 ? -1 : 1), ForceMode.Force);
    }

    private void OnCollisionEnter(Collision collision)
    {
        _hp.ReduceHP(_rb.velocity.magnitude);
    }

    public void RapidsChanged()
    {
        float angle = transform.rotation.eulerAngles.y;
        if (angle > 30) _hp.ReduceHP(angle);
    }
}