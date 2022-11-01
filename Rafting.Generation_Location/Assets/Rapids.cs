using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rapids : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        if (col.GetComponent<Player>() != null)
        {
            Water.SWater.SetSpeed(transform.rotation.eulerAngles.x / 5);
        }
    }
}