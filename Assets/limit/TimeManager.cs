using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeManager : MonoBehaviour
{
    public GameObject image;

    const float TIMELIMIT = 10f;
    //　制限時間（秒）
    [SerializeField] private float seconds;
    //　前回Update時の秒数
    private float oldSeconds;
    private TextMeshProUGUI timerText;
    private Vector2 firstPos;

    void Start()
    {
        //totalTime = minute * 60 + seconds;
        image.SetActive(false);
        firstPos = image.transform.position;
        seconds = TIMELIMIT;
        oldSeconds = 0f;
        timerText = GetComponentInChildren<TextMeshProUGUI>();
    }

    void Update()
    {
        //Resetを呼び出す
        if (Input.GetMouseButtonDown(0)) 
        {
            TimerReset();
        }

        if (seconds < 5f)
        {
            image.SetActive(true);

        }

        //　制限時間が0秒以下なら何もしない
        if (seconds <= 0f)
        {
            return;
        }
        //　一旦トータルの制限時間を計測；
        //totalTime = minute * 60 + seconds;
        seconds -= Time.deltaTime;

        //　再設定
        //minute = (int)totalTime / 60;
        seconds = Mathf.Max(0, seconds);

        //　タイマー表示用UIテキストに時間を表示する
        if ((float)seconds != (float)oldSeconds)
        {
            timerText.text = ((float)seconds).ToString("00.00");
        }
        oldSeconds = seconds;
        //　制限時間以下になったらコンソールに『制限時間終了』という文字列を表示する
        if (seconds <= 0f)
        {
            Debug.Log("制限時間終了");
        }
    }

    public void TimerReset()
    {
        image.SetActive(false);
        image.transform.position = firstPos;
        seconds = TIMELIMIT;
        oldSeconds = 0f;
    }
}
