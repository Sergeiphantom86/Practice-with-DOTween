using DG.Tweening;
using UnityEngine;

public class Rotator : Changer
{
    [SerializeField] private RotateMode _rotateMOde;

    private void Start()
    {
        transform.DORotate(new Vector3(), Duration, _rotateMOde).SetLoops(Repeats, LoopeType);
    }
}