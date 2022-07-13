using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOverUI : MonoBehaviour
{
    
    public TextMeshProUGUI _bestTimeUI;
    // Start is called before the first frame update
    

    public void Activate(int bestTime)
    {
        gameObject.SetActive(true);
        _bestTimeUI.text = $"�ְ��� : {bestTime}��";
        //_bestTimeUI.text.Replace("~", bestTime.ToString());
    }
}
