using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CharacterMenuClickHandler : MonoBehaviour, IPointerClickHandler
{
    

    public void OnPointerClick(PointerEventData eventData)
    {
        if (gameObject.name == "1_char_image")
        {
            CharacterMenuController.NumberOfChoosenChar = 1;
            CharacterMenuController.OnCharClicked.Invoke();
        }

        else if (gameObject.name == "2_char_image")
        {
            CharacterMenuController.NumberOfChoosenChar = 2;
            CharacterMenuController.OnCharClicked.Invoke();
        }
    }
}
