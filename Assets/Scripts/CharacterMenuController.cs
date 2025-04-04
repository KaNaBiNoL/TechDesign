using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class CharacterMenuController : MonoBehaviour
{
    public static int NumberOfChoosenChar = 0;
    public static UnityEvent OnCharClicked = new UnityEvent();
    [SerializeField] private Animator _firstCharAnimator;
    [SerializeField] private Animator _secondCharAnimator;
    [SerializeField] private ParticleSystem _firstCharParticles;
    [SerializeField] private ParticleSystem _secondCharParticles;
    [SerializeField] private Button _confirmButton;
    [SerializeField] private AudioSource _firstCharSound;
    [SerializeField] private AudioSource _secondCharSound;
    

    private void OnEnable()
    {
        OnCharClicked.AddListener(CharClickCallback);
    }

    void Start()
    {
        _confirmButton.interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void CharClickCallback()
    {
        switch (NumberOfChoosenChar)
        {
            case 1:
                _firstCharAnimator.SetTrigger("CharacterChosen");
                _firstCharSound.Play();
                _confirmButton.interactable = true;
                _firstCharParticles.gameObject.SetActive(true);
                _secondCharParticles.gameObject.SetActive(false);
                PlayerPrefs.SetInt("SelectedCharacter", NumberOfChoosenChar);
                break;
            case 2:
                _secondCharAnimator.SetTrigger("CharacterChosen");
                _secondCharSound.Play();
                _confirmButton.interactable = true;
                _firstCharParticles.gameObject.SetActive(false);
                _secondCharParticles.gameObject.SetActive(true);
                PlayerPrefs.SetInt("SelectedCharacter", NumberOfChoosenChar);
                break;
        }
    }

    private void OnDisable()
    {
        OnCharClicked.RemoveListener(CharClickCallback);
    }
}