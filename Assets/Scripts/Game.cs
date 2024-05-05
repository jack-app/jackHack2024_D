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

    // Start is called before the first frame update
    void Start()
    {
        GameObject image_object = GameObject.Find("Scene");
        Image image_component = image_object.GetComponent<Image>();
        Texture2D texture = Resources.Load("test") as Texture2D;
        image_component.sprite = Sprite.Create(texture,
                                new Rect(0, 0, texture.width, texture.height),
                                Vector2.zero);

        InstantiateUIBtn(parent, "ButtonL", -136, -110);
        InstantiateUIBtn(parent, "ButtonR", 136, -110);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InstantiateUIBtn(GameObject parent, string name, float pos_x, float pos_y)
    {
        GameObject ui_btn = Instantiate(this.btn, new Vector3(pos_x, pos_y, 1), Quaternion.identity);

        // パネルを親に指定
        ui_btn.transform.SetParent(this.parent.transform,false);
        ui_btn.name = name;

        // クリックイベントを付与
        ui_btn.GetComponent<Button>().onClick.AddListener(() => BtnOnClick(ui_btn));
    }

    void BtnOnClick(GameObject btn)
    {
        Debug.Log("button: " + btn.name);
        popuptext.text = "test";
        GameObject obj = GameObject.Find("ButtonL");
        Destroy(obj);
        obj = GameObject.Find("ButtonR");
        Destroy(obj);
        
        StartCoroutine(DelayCoroutine(3,() =>
        {
        InstantiateUIBtn(parent, "ButtonL", -136, -110);
        InstantiateUIBtn(parent, "ButtonR", 136, -110);
        popuptext.text = "";
        }));
    }

    private IEnumerator DelayCoroutine(float seconds, Action action)
    {
        yield return new WaitForSeconds(seconds);
        action?.Invoke();
    }
}
