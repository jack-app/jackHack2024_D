using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject btn;
    public GameObject parent;

    // Start is called before the first frame update
    void Start()
    {
        InstantiateUIBtn(parent, "Button", 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InstantiateUIBtn(GameObject parent, string name, float pos_x, float pos_y)
    {
        GameObject ui_btn = Instantiate(this.btn, new Vector3(pos_x, pos_y, 0), Quaternion.identity);

        // パネルを親に指定
        ui_btn.transform.SetParent(this.parent.transform,false);
        ui_btn.name = name;

        // クリックイベントを付与
        ui_btn.GetComponent<Button>().onClick.AddListener(() => BtnOnClick(ui_btn));
    }

    void BtnOnClick(GameObject btn){
        Debug.Log("button: " + btn.name);
    }
}
