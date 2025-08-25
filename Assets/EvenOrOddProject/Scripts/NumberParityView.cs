using TMPro;
using UnityEngine;

public class NumberParityView : MonoBehaviour
{
    [SerializeField] private TMP_Text _outputNumber;

    public void Clear()
    {
        _outputNumber.text = "-";
    }

    public void DisplayNumber(int number)
    {
        _outputNumber.text = number.ToString();
    }
}
