using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour
{
    [SerializeField] float _power = 10;

    Dictionary<Collider, Rigidbody> entitys = new Dictionary<Collider, Rigidbody>();

    private void OnTriggerEnter(Collider other)
    {
        Rigidbody body = other.GetComponent<Rigidbody>();
        if (body != null) entitys.Add(other, body);
    }
    private void OnTriggerStay(Collider other)
    {
        if (entitys.ContainsKey(other))
        {
            Vector3 tangent2D = GetTangent2D(transform.position, other.transform.position);

            entitys[other].AddTorque(new Vector3(0, Vector3.Distance(transform.position, other.transform.position) * _power * ((tangent2D.x > 0) ? 1 : -1), 0), ForceMode.Force);

            entitys[other].AddForce(tangent2D, ForceMode.Force);
        }
    }

    Vector3 GetTangent2D(Vector3 centr, Vector3 boat)
    {
        Vector3 normal = (boat - centr).normalized / Vector3.Distance(boat, centr) * _power;

        if (normal.x > 0) return new Vector3(-normal.z, 0, normal.x);
        else return new Vector3(normal.z, 0, -normal.x);
    }
}