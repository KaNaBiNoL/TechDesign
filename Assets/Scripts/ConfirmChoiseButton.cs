using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ConfirmChoiseButton : MonoBehaviour
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
        _anim.SetTrigger("ButtonPressed");
        _buttonSound.Play();
    }

    private void OnAnimationEvent()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
    
    private void OnDisable()
    {
        _thisButton.onClick.RemoveListener(ButtonAnimationStarted);
    }
}
