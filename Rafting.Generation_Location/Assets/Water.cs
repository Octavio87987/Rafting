using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{
    public static Water SWater;
    [SerializeField] float _speed = 1;

    Dictionary<Collider, Rigidbody> _objects = new Dictionary<Collider, Rigidbody>();
    [SerializeField] float _force = 1;

    void Start()
    {
        SWater = this;
    }

    void Update()
    {
        //transform.position += _speed * Vector3.forward * Time.deltaTime * -1;
    }

    public void SetSpeed(float angle)
    {
        _speed = angle;
    }

    private void OnTriggerEnter(Collider other)
    {
        Rigidbody obj = other.GetComponent<Rigidbody>();
        if (obj != null)
        {
            _objects.Add(other, obj);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (_objects.ContainsKey(other))
        {
            _objects[other].AddForce(Vector3.up * Mathf.Abs(Physics.gravity.y + _objects[other].velocity.y) * (other.transform.position.y - transform.position.y + 2), ForceMode.Force);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (_objects.ContainsKey(other))
        {
            _objects.Remove(other);
        }
    }
}