using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BackToMenuButton : MonoBehaviour
{
    [SerializeField] private Button _thisButton;
    [SerializeField] private Animator _anim;
    [SerializeField] private AudioSource _buttonSound;
    
    

    private void OnEnable()
    {
        _thisButton.onClick.AddListener(ButtonAnimationStarted);
    }

    private void ButtonAnimationStarted()
    {
        _buttonSound.Play();
        _anim.SetTrigger("ButtonPressed");
    }

    private void OnAnimationEvent()
    {
        SceneManager.LoadScene(0);
    }
    
    private void OnDisable()
    {
        _thisButton.onClick.RemoveListener(ButtonAnimationStarted);
    }
}
