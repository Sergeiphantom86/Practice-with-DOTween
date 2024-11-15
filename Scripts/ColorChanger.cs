using DG.Tweening;
using UnityEngine;

public class ColorChanger : Changer
{
    [SerializeField] private Material _material ;
    [SerializeField] private Color _color;

    private void Start()
    {
        _material.DOColor(_color, Duration).SetLoops(Repeats, LoopeType);
    }
}