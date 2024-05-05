using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimeController : MonoBehaviour
{
    public TextMeshProUGUI timeLabel;
    private float timeCount = 0;

    void Start()
    {
        // 小数点２位まで表示
        timeLabel.text = "TIME：" + timeCount.ToString("n2");
    }

    void Update()
    {
        timeCount += Time.deltaTime;
        timeLabel.text = "TIME：" + timeCount.ToString("n2");
    }
}

