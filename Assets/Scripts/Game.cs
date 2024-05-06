using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Game : MonoBehaviour
{
    public GameObject btn;
    public GameObject parent;
    public TextMeshProUGUI popuptext;

    public TextMeshProUGUI explanatorytext;
    public Question question;
    int i = 1;

    // Start is called before the first frame update
    void Start()
    {
        // Questionから配列の取得
        question = GetComponent<Question>();
        // 画像の名前を取得
        string picname = question.QuestionSen[0, 0];
        // シーンの画像配置
        GameObject image_object = GameObject.Find("Scene");
        Image image_component = image_object.GetComponent<Image>();
        Texture2D texture = Resources.Load(picname) as Texture2D;
        image_component.sprite = Sprite.Create(texture,
                                new Rect(0, 0, texture.width, texture.height),
                                Vector2.zero);
        
        // シーンの説明文
        explanatorytext.text = question.QuestionSen[0,1];

        // ボタン設置
        InstantiateUIBtn(parent, "ButtonL", -136, -140, question.QuestionSen[0,2]);
        InstantiateUIBtn(parent, "ButtonR", 136, -140, question.QuestionSen[0,3]);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InstantiateUIBtn(GameObject parent, string name, float pos_x, float pos_y, string buttontext)
    {
        GameObject ui_btn = Instantiate(this.btn, new Vector3(pos_x, pos_y, 1), Quaternion.identity);

        // パネルを親に指定
        ui_btn.transform.SetParent(this.parent.transform,false);
        ui_btn.name = name;
        TextMeshProUGUI ui_btn_text = ui_btn.GetComponentInChildren<TextMeshProUGUI>();
        ui_btn_text.text = buttontext;

        // クリックイベントを付与
        ui_btn.GetComponent<Button>().onClick.AddListener(() => BtnOnClick(ui_btn));
    }

    void BtnOnClick(GameObject btn)
    {
        GameObject image_object = GameObject.Find("Scene");
        Image image_component = image_object.GetComponent<Image>();

        // 正解・不正解の表示
        Debug.Log("button: " + btn.name);
        popuptext.text = "test";
        // ボタンの破壊
        GameObject obj = GameObject.Find("ButtonL");
        Destroy(obj);
        obj = GameObject.Find("ButtonR");
        Destroy(obj);
        
        StartCoroutine(DelayCoroutine(3,() =>
        {
        // ボタンの再設置
        InstantiateUIBtn(parent, "ButtonL", -136, -140, question.QuestionSen[i, 2]);
        InstantiateUIBtn(parent, "ButtonR", 136, -140, question.QuestionSen[i, 3]);
        popuptext.text = "";
        string picname = question.QuestionSen[i,0];
        Texture2D texture = Resources.Load(picname) as Texture2D;
        image_component.sprite = Sprite.Create(texture,
                                new Rect(0, 0, texture.width, texture.height),
                                Vector2.zero);
        explanatorytext.text = question.QuestionSen[i,1];
        i += 1;
        }));
    }

    private IEnumerator DelayCoroutine(float seconds, Action action)
    {
        yield return new WaitForSeconds(seconds);
        action?.Invoke();
    }
}
