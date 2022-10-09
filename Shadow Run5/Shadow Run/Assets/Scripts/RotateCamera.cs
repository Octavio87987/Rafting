using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    [SerializeField] private Animator CameraAnim;

    [SerializeField] private float maxTime; 
    void Start()
    {
        CameraAnim = GetComponent<Animator>(); 
    }
     
    void Update()
    {
        if (maxTime > 25)
        {
            CameraAnim.SetBool("isRotate",true);
        }

        if (maxTime > 40)
        {
            CameraAnim.SetBool("isRotate", false);
            maxTime = 0; 
        }
        maxTime += Time.deltaTime;
    }
}
