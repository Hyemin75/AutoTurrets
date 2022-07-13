using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
    public TimerText Timer;
    public GameOverUI GameOverUI;

    private bool _isOver;
    private void Update()
    {
        //���࿡ ������ ���ᰡ �Ǿ��ٸ�
        //RŰ�� �����ٸ� �����
        if(_isOver && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
        }
    }


    public void End()
    {
        Timer.IsOn = false;

        //������ ����
        int savedBestTime = PlayerPrefs.GetInt("BestTime", 0);
        int bestTime = Math.Max(Timer.SurvivalTime, savedBestTime) ;
        PlayerPrefs.SetInt("BestTime", bestTime);

        
        if(bestTime < savedBestTime)
        {
            bestTime = savedBestTime;
        }
        
      
        PlayerPrefs.SetInt("BesetTime", bestTime);
        

        //GameOverUI�� ����
        GameOverUI.Activate(bestTime);

        //_isOver = true;
        _isOver = true;
    }

}
