using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    [SerializeField] private TimerView _timerView;
    [SerializeField] private UnityEvent _timerFinished;
    [SerializeField] private float _startTime = 10f;
    [SerializeField] private float _countdownInterval = 0.1f;

    private Coroutine _timerCoroutine;
    public bool IsTimerRunning => _timerCoroutine != null;

    public void Stop()
    {
        StopCoroutineIfActive();
    }

    public void Start()
    {
        StopCoroutineIfActive();
        StartNewCoroutine();
    }

    private void StopCoroutineIfActive()
    {
        if (IsTimerRunning)
        {
            StopCoroutine(_timerCoroutine);
            _timerCoroutine = null;
        }
    }

    private void StartNewCoroutine()
    {
        _timerCoroutine = StartCoroutine(CountdownTimer(_startTime, _countdownInterval));
    }

    private IEnumerator CountdownTimer(float startTime, float countdownInterval)
    {
        float remainingTime = startTime;
        WaitForSeconds waitInterval = new(countdownInterval);
        do
        {
            yield return waitInterval;
            remainingTime -= countdownInterval;
            remainingTime = Mathf.Max(remainingTime, 0f);
            _timerView.DisplayTime(startTime, remainingTime);
        }
        while (remainingTime > 0);

        _timerCoroutine = null;
        _timerFinished.Invoke();
    }
}
