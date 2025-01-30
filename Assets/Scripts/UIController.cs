using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField] private GameObject _endScreen;
    [SerializeField] private GameObject _winScreen;

    public void OnWinScreen()
    {
        _winScreen.SetActive(true);
    }

    public void OnEndScreen()
    {
        _endScreen.SetActive(true);
    }
    
}
