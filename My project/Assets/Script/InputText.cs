using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InputText : MonoBehaviour
{
    public TextMeshProUGUI Text_Text; // �ؽ�Ʈ�� ���� ��
    [SerializeField] TMP_InputField Input_Text; // ��� �ؽ�Ʈ�� ������ ����
    public void OnClickButton()
    {
        Text_Text.text = Input_Text.text;
    }
}
