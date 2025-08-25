using UnityEngine;

public class AnswerTracker : MonoBehaviour
{
    [SerializeField] private AnswerTrackerView _answerTrackerView;

    private int _counter = 0;

    public void Reset()
    {
        _counter = 0;
        _answerTrackerView.Display(_counter);
    }

    public void Track()
    {
        _counter++;
        _answerTrackerView.Display(_counter);
    }
}
