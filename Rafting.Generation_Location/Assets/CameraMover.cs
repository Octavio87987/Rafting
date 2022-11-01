using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CameraMover : MonoBehaviour, IDragHandler
{
    [SerializeField] Camera _mapCamera;
    [SerializeField] Transform _target;
    [SerializeField] Vector3 _offSet;

    public void OnDrag(PointerEventData eventData)
    {
        if (Input.touchCount == 2)
        {
            // масштабировать камеру
            float oldDist = Vector2.Distance(Input.GetTouch(0).position, Input.GetTouch(1).position);
            float newDist = Vector2.Distance(Input.GetTouch(0).position - Input.GetTouch(0).deltaPosition, Input.GetTouch(1).position - Input.GetTouch(1).deltaPosition);
            float size = 1;

            if (oldDist > newDist) size = -1;

            _mapCamera.transform.position += transform.forward * newDist / oldDist * size;
        }
    }

    void Update()
    {
        _mapCamera.transform.position = _target.position + _offSet;
        transform.LookAt(_target);
    }
}