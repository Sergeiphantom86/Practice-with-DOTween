using DG.Tweening;
using UnityEngine;

public class Size : Changer
{
    [SerializeField] private Transform _target;

    private void Start()
    {
        transform.DOScale(_target.lossyScale, Duration).SetLoops(Repeats, LoopeType);
    }
}