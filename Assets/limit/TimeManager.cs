using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeManager : MonoBehaviour
{
    public GameObject image;

    const float TIMELIMIT = 10f;
    //�@�������ԁi�b�j
    [SerializeField] private float seconds;
    //�@�O��Update���̕b��
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
        //Reset���Ăяo��
        if (Input.GetMouseButtonDown(0)) 
        {
            TimerReset();
        }

        if (seconds < 5f)
        {
            image.SetActive(true);

        }

        //�@�������Ԃ�0�b�ȉ��Ȃ牽�����Ȃ�
        if (seconds <= 0f)
        {
            return;
        }
        //�@��U�g�[�^���̐������Ԃ��v���G
        //totalTime = minute * 60 + seconds;
        seconds -= Time.deltaTime;

        //�@�Đݒ�
        //minute = (int)totalTime / 60;
        seconds = Mathf.Max(0, seconds);

        //�@�^�C�}�[�\���pUI�e�L�X�g�Ɏ��Ԃ�\������
        if ((float)seconds != (float)oldSeconds)
        {
            timerText.text = ((float)seconds).ToString("00.00");
        }
        oldSeconds = seconds;
        //�@�������Ԉȉ��ɂȂ�����R���\�[���Ɂw�������ԏI���x�Ƃ����������\������
        if (seconds <= 0f)
        {
            Debug.Log("�������ԏI��");
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
