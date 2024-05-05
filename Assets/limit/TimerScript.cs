using UnityEngine;
using System.Collections;
using UnityEngine.UI;
 
public class TimerScript : MonoBehaviour
{

    [SerializeField]
    private int minute;
    [SerializeField]
    private float seconds;
    //�@�O��Update�̎��̕b��
    private float oldSeconds;
    //�@�^�C�}�[�\���p�e�L�X�g
    private Text timerText;

    void Start()
    {
        minute = 0;
        seconds = 0f;
        oldSeconds = 0f;
        timerText = GetComponentInChildren<Text>();
    }

    void Update()
    {
        seconds += Time.deltaTime;
        if (seconds >= 60f)
        {
            minute++;
            seconds = seconds - 60;
        }
        //�@�l���ς�����������e�L�X�gUI���X�V
        if ((float)seconds != (float)oldSeconds)
        {
            timerText.text = minute.ToString("00") + ":" + ((float)seconds).ToString("00");
        }
        oldSeconds = seconds;
    }
}