using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickableTower : MonoBehaviour
{
    [SerializeField] private Animator _towerAnimator;

    private void OnMouseDown()
    {
        _towerAnimator.SetTrigger("TowerClicked");
    }
}
