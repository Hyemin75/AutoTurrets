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
        //만약에 게임이 종료가 되었다면
        //R키를 눌렀다면 재시작
        if(_isOver && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
        }
    }


    public void End()
    {
        Timer.IsOn = false;

        //데이터 저장
        int savedBestTime = PlayerPrefs.GetInt("BestTime", 0);
        int bestTime = Math.Max(Timer.SurvivalTime, savedBestTime) ;
        PlayerPrefs.SetInt("BestTime", bestTime);

        
        if(bestTime < savedBestTime)
        {
            bestTime = savedBestTime;
        }
        
      
        PlayerPrefs.SetInt("BesetTime", bestTime);
        

        //GameOverUI에 갱신
        GameOverUI.Activate(bestTime);

        //_isOver = true;
        _isOver = true;
    }

}
