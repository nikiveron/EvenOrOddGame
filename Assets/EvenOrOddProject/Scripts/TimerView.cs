using UnityEngine;
using UnityEngine.UI;

public class TimerView : MonoBehaviour
{
    [SerializeField] private Slider _timerSlider;

    public void DisplayTime(float startTime, float remainingTime)
    {
        _timerSlider.value = remainingTime / startTime;
    }
}
