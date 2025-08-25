using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject _menuScreen;
    [SerializeField] private GameObject _playScreen;
    [SerializeField] private Timer _timer;
    [SerializeField] private NumberParity _numberParity;
    [SerializeField] private Button _evenNumberButton;
    [SerializeField] private Button _oddNumberButton;
    [SerializeField] private Button _restartButton;

    private void Start()
    {
        SwitchToMenuScreen();
    }

    private void Update()
    {
        
    }

    private void SwitchToMenuScreen()
    {
        _menuScreen.SetActive(true);
        _playScreen.SetActive(false);
    }

    private void SwitchToPlayScreen()
    {
        _menuScreen.SetActive(false);
        _playScreen.SetActive(true);
    }

    public void OnGameStart()
    {
        SwitchToPlayScreen();
        SwitchButtonsToPlayGameState();
        _timer.Start();
        _numberParity.Restart();
    }

    public void OnGameEnd()
    {
        _timer.Stop();
        SwitchButtonsToEndGameState();
    }

    public void OnMainMenu()
    {
        SwitchToMenuScreen();
        _timer.Stop();
        _numberParity.Clear();
    }

    public void OnGameRestart()
    {
        SwitchButtonsToPlayGameState();
        _timer.Start();
        _numberParity.Restart();
    }

    private void SwitchButtonsToPlayGameState()
    {
        _evenNumberButton.interactable = true;
        _oddNumberButton.interactable = true;
        _restartButton.interactable = false;
    }
    private void SwitchButtonsToEndGameState()
    {
        _evenNumberButton.interactable= false;
        _oddNumberButton.interactable = false;
        _restartButton.interactable = true;
    }
}
