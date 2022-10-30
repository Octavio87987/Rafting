using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Paddle : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] Player _player;
    Vector2 _rowStart;
    RectTransform _rectTransform;

    [SerializeField] bool _rightPaddle;

    void Start()
    {
        _rectTransform = GetComponent<RectTransform>();
    }

    public void OnPointerDown(PointerEventData ped)
    {
        _rowStart = ped.position;
    }

    public void OnPointerUp(PointerEventData ped)
    {
        _player.Row((_rowStart - ped.position).y / _rectTransform.sizeDelta.y, _rightPaddle);
    }
}