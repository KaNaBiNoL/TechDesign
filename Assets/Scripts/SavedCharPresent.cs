using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavedCharPresent : MonoBehaviour
{
    [SerializeField] private GameObject _char_1;
    [SerializeField] private GameObject _char_2;
    private int _selectedCharNumber;
    
    void Start()
    {
       _selectedCharNumber = PlayerPrefs.GetInt("SelectedCharacter");
       if (_selectedCharNumber == 1)
       {
           _char_1.SetActive(true);
           _char_2.SetActive(false);
       }

       else if (_selectedCharNumber == 2)
       {
           _char_1.SetActive(false);
           _char_2.SetActive(true);
       }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
