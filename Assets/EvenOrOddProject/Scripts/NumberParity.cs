using UnityEngine;
using System;
using System.Collections;

public class NumberParity : MonoBehaviour
{
    [SerializeField] private NumberParityView _numberParityView;
    [SerializeField] private int _minNumberValue = 0;
    [SerializeField] private int _maxNumberValue = 100;
    [SerializeField] private AnswerTracker _correctTracker;
    [SerializeField] private AnswerTracker _incorrectTracker;

    private int _number;
    private bool _isNumberEven => _number % 2 == 0;

    public void Restart()
    {
        _correctTracker.Reset();
        _incorrectTracker.Reset();
        _numberParityView.Clear();
        GetNumber();
    }

    public void Clear()
    {
        _numberParityView.Clear();
        _correctTracker.Reset();
        _incorrectTracker.Reset();
    }

    public void OnEvenButtonClick()
    {
        if (_isNumberEven) _correctTracker.Track();
        else _incorrectTracker.Track();
        GetNumber();
    }

    public void OnOddButtonClick()
    {
        if (_isNumberEven) _incorrectTracker.Track();
        else _correctTracker.Track();
        GetNumber();
    } 

    public void GetNumber()
    {
        var rnd = new System.Random();
        _number = rnd.Next(_minNumberValue, _maxNumberValue);
        _numberParityView.DisplayNumber(_number);
    }
}
