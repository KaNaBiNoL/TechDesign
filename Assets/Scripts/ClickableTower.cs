using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickableTower : MonoBehaviour
{
    [SerializeField] private Animator _towerAnimator;
    [SerializeField] private AudioSource _towerRiseSound;
    [SerializeField] private AudioSource _towerFallSound;
    [SerializeField] private AudioSource _projectileBoomSound;

    public void PlayRiseSound()
    {
        _towerRiseSound.Play();
    }

    public void PlayFallSound()
    {
        _towerFallSound.Play();
    }

    public void PlayBoomSound()
    {
        _projectileBoomSound.Play();
    }
    private void OnMouseDown()
    {
        _towerAnimator.SetTrigger("TowerClicked");
    }
    
    
}
