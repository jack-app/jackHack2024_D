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

    //�@�g�[�^����������
    //private float totalTime;
    //�@�������ԁi���j
    //[SerializeField] private int minute;
    public GameObject image;

    //�@�������ԁi�b�j
    [SerializeField] private float seconds;
    //�@�O��Update���̕b��
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
        seconds = Mathf.Max(0,seconds);

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
}