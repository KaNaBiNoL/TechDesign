using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Settings;
using UnityEngine.UI;

public class LocalizationSet : MonoBehaviour
{
    [SerializeField] private Button englishButton;
    [SerializeField] private Button russianButton;
    [SerializeField] private Button spanishButton;
    [SerializeField] private Animator _enButtonAnimator;
    [SerializeField] private Animator _ruButtonAnimator;
    [SerializeField] private Animator _esButtonAnimator;
    [SerializeField] private AudioSource _buttonSound;
    

    private void Start()
    {
        if (LocalizationSettings.InitializationOperation.IsDone)
        {
            SetupButtons();
        }
        else
        {
            LocalizationSettings.InitializationOperation.Completed += (operation) => SetupButtons();
        }
    }

    private void SetupButtons()
    {
        englishButton.onClick.AddListener(() => ChangeLanguage(0));
        russianButton.onClick.AddListener(() => ChangeLanguage(1));
        spanishButton.onClick.AddListener(() => ChangeLanguage(2));
    }

    private void ChangeLanguage(int localeIndex)
    {
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[localeIndex];
        switch (localeIndex)
        {
            case 0:
                _enButtonAnimator.SetTrigger("ButtonPressed");
                break;
            case 1:
                _ruButtonAnimator.SetTrigger("ButtonPressed");
                break;
            case 2:
                _esButtonAnimator.SetTrigger("ButtonPressed");
                break;
        }
        _buttonSound.Play();
    }

    private void OnDisable()
    {
        englishButton.onClick.RemoveListener(() => ChangeLanguage(0));
        russianButton.onClick.RemoveListener(() => ChangeLanguage(1));
        spanishButton.onClick.RemoveListener(() => ChangeLanguage(2));
    }
}