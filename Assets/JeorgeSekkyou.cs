using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;


public class RandomText : MonoBehaviour
{
    // TextMeshProのテキストオブジェクト
    public TMP_Text textMeshPro;

    // 表示させるテキストの配列
    private string[] sekkyou = { "Yowaitte", "Kibishiitte", "Motenaitte", "Amaitte" };

    void Start()
    {
        // ランダムに説教
        DisplayRandomFruit();
    }

    // ランダム叱る関数
    void DisplayRandomFruit()
    {
        // ランダムなインデックスを生成
        int randomIndex = Random.Range(0, sekkyou.Length);

        // ランダムな説教分
        textMeshPro.text = sekkyou[randomIndex];
    }
}