using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
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
                _confirmButton.interactable = true;
                _firstCharParticles.gameObject.SetActive(true);
                _secondCharParticles.gameObject.SetActive(false);
                break;
            case 2:
                _secondCharAnimator.SetTrigger("CharacterChosen");
                _confirmButton.interactable = true;
                _firstCharParticles.gameObject.SetActive(false);
                _secondCharParticles.gameObject.SetActive(true);
                break;
        }
    }

    private void OnDisable()
    {
        OnCharClicked.RemoveListener(CharClickCallback);
    }
}