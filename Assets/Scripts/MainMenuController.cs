using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    [SerializeField] private Button _startGameButton;
    [SerializeField] private Button _quitGameButton;
    [SerializeField] private Animator _startGameButtonAnim;
    [SerializeField] private Animator _quitGameButtonAnim;
    [SerializeField] private AudioSource _buttonSound;

    private void OnEnable()
    {
        _startGameButton.onClick.AddListener(StartGamePlay);
        _quitGameButton.onClick.AddListener(QuitGame);
    }

    void Start()
    {
    }

    private void StartGamePlay()
    {
        _startGameButtonAnim.SetTrigger("ButtonPressed");
        _buttonSound.Play();
    }

    private void QuitGame()
    {
        _quitGameButtonAnim.SetTrigger("ButtonPressed");
        _buttonSound.Play();
    }

    private void OnDisable()
    {
        _startGameButton.onClick.RemoveListener(StartGamePlay);
        _quitGameButton.onClick.RemoveListener(QuitGame);
    }
}