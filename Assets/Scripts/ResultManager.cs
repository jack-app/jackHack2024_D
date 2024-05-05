using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ResultManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI commentText;

    [SerializeField] private int correctNumber = 0;

    string[] comments =  { "<size=48>厳しいって。\nモテないって。", "<size=48>男としてのパーツが\n足りてないって。", "<size=48>モテないよ、普通に。", "<size=36>女の子はどういう男性を\n求めてる？格上の存在だよね。\r\n", "<size=36>全問正解できないようじゃ\n弱いって。", "<size=48>これくらいできて\n当然だって。" };
    
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
