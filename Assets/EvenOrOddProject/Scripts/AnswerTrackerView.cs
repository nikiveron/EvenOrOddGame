using TMPro;
using UnityEngine;

public class AnswerTrackerView : MonoBehaviour
{
    [SerializeField] private TMP_Text _outputField;

    public void Display(int counter)
    {
        _outputField.text = counter.ToString();
    }
}
