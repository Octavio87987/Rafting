using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateLong : MonoBehaviour
{
    [SerializeField] private float speedRotate;

    // Start is called before the first frame update
    void Start()
    {
        speedRotate = Random.Range(-0.1f, 1.5f);    
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, speedRotate, 0);
    }
}
