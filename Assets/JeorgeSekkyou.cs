using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;


public class RandomText : MonoBehaviour
{
    // TextMeshPro�̃e�L�X�g�I�u�W�F�N�g
    public TMP_Text textMeshPro;

    // �\��������e�L�X�g�̔z��
    private string[] sekkyou = { "Yowaitte", "Kibishiitte", "Motenaitte", "Amaitte" };

    void Start()
    {
        // �����_���ɐ���
        DisplayRandomFruit();
    }

    // �����_������֐�
    void DisplayRandomFruit()
    {
        // �����_���ȃC���f�b�N�X�𐶐�
        int randomIndex = Random.Range(0, sekkyou.Length);

        // �����_���Ȑ�����
        textMeshPro.text = sekkyou[randomIndex];
    }
}