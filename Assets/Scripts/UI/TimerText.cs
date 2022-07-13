using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimerText : MonoBehaviour
{

    public int SurvivalTime { get; private set; }
    public bool IsOn { get; set; }


    private float _elpasedtime;
    private TextMeshProUGUI _ui;

    
    void Start()
    {
        _ui = GetComponent<TextMeshProUGUI>();
        _ui.text = $"시간 : {SurvivalTime}초";
        IsOn = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (IsOn)
        {
            _elpasedtime += Time.deltaTime;
            if (_elpasedtime >= 1.0f)
            {
                //1초에 한번씩만 업데이트 되도록
                ++SurvivalTime;
                _elpasedtime -= 1f;
                _ui.text = $"시간 : {SurvivalTime}초";
            }
        }
    }
}
