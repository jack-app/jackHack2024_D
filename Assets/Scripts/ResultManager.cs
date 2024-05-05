using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ResultManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI commentText;

    [SerializeField] private int correctNumber = 0;

    string[] comments =  { "<size=48>���������āB\n���e�Ȃ����āB", "<size=48>�j�Ƃ��Ẵp�[�c��\n����ĂȂ����āB", "<size=48>���e�Ȃ���A���ʂɁB", "<size=36>���̎q�͂ǂ������j����\n���߂Ă�H�i��̑��݂���ˁB\r\n", "<size=36>�S�␳���ł��Ȃ��悤����\n�ア���āB", "<size=48>���ꂭ�炢�ł���\n���R�����āB" };
    
    // Start is called before the first frame update
    void Start()
    {
        //collectNumber = ;
        scoreText.text = "Score: " + correctNumber.ToString();
        if (correctNumber < 5)
        {
            commentText.text = comments[0];
        }
        else if (correctNumber < 10)
        {
            commentText.text = comments[1];
        }
        else if (correctNumber < 15)
        {
            commentText.text = comments[2];
        }
        else if (correctNumber < 20)
        {
            commentText.text = comments[3];
        }
        else if (correctNumber < 25) 
        {
            commentText.text = comments[4];
        }
        else if (correctNumber <= 30)
        {
            commentText.text = comments[5];
        }
    }
}
