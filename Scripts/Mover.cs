using DG.Tweening;
using UnityEngine;

public class Mover : Changer
{
    [SerializeField] private Transform _target;

    private void Start()
    {
        transform.DOMove(_target.position, Duration).SetLoops(Repeats, LoopeType);
    }
}