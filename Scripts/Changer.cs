using DG.Tweening;
using UnityEngine;

public class Changer : MonoBehaviour
{
    [SerializeField] private LoopType _loopeType;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;

    public LoopType LoopeType { get; private set; }
    public float Duration { get; private set; }
    public int Repeats { get; private set; }

    private void Awake()
    {
        LoopeType = _loopeType;
        Duration = _duration;
        Repeats = _repeats;
    }
}
