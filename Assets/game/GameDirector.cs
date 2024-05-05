using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using Microsoft.Unity.VisualStudio.Editor;

public class GameDitector : MonoBehaviour
{
    /*GameObject timerText;
    GameObject pointText;
    GameObject generator;
    float time = 15.0f;


    void Start()
    {
        timerText = GameObject.Find("Time");
        generator = GameObject.Find("ItemGenerator");
    }

    void Update()
    {
        time -= Time.deltaTime;

        if (time < 0)
        {
            time = 0;
            // generator.GetComponent<I
        }
    }*/

    //　トータル制限時間
    //private float totalTime;
    //　制限時間（分）
    //[SerializeField] private int minute;
    public GameObject image;

    //　制限時間（秒）
    [SerializeField] private float seconds;
    //　前回Update時の秒数
    private float oldSeconds;
    private TextMeshProUGUI timerText;

    void Start()
    {
        //totalTime = minute * 60 + seconds;
        image.SetActive(false);
        oldSeconds = 0f;
        timerText = GetComponentInChildren<TextMeshProUGUI>();
    }

    void Update()
    {
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
        seconds = Mathf.Max(0,seconds);

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
}