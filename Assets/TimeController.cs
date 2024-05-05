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
        // �����_�Q�ʂ܂ŕ\��
        timeLabel.text = "TIME�F" + timeCount.ToString("n2");
    }

    void Update()
    {
        timeCount += Time.deltaTime;
        timeLabel.text = "TIME�F" + timeCount.ToString("n2");
    }
}

