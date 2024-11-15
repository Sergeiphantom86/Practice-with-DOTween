using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _replacementText;
    [SerializeField] private Text _textForSupplement;
    [SerializeField] private Text _hackingText;
    [SerializeField] private float _duration;

    void Start()
    {
        Replace(_replacementText);
        Complement(_textForSupplement);
        Hack(_hackingText);
    }

    private void Replace(Text text)
    {
        text.DOText("� ������ ���� �����", _duration);
    }

    private void Complement(Text text)
    {
        text.DOText("��� ���������� � ������", _duration).SetRelative();
    }

    private void Hack(Text text)
    {
        text.DOText("����� ����� ������", _duration, true, ScrambleMode.All);
    }
}