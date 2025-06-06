using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Test : MonoBehaviour
{
    //�ڱ� �Ұ�
    private string monsterName = "���";
    private int monsterAge = 15;
    private int monsterHeight = 128;
    private string monsterGender = "����";
    private string monsterMbti = "infj";

    private void Start()
    {
        MonsterIntroduce();
        MonsterIntroduce2("��ũ", 19, 220, "����", "intp");
    }

    public void MonsterIntroduce()
    {
        Debug.Log($"���� �̸��� {monsterName} �Դϴ�.");
        Debug.Log($"���� {monsterAge}�� �Դϴ�.");
        Debug.Log($"���� Ű�� {monsterHeight}cm �Դϴ�.");
        Debug.Log($"���� {monsterGender} �Դϴ�.");
        Debug.Log($"���� MBTI�� {monsterMbti} �Դϴ�.");
    }

    public void MonsterIntroduce2(string name, int age, int height, string gender, string mbti)
    {
        Debug.Log($"���� �̸��� {name} �Դϴ�.");
        Debug.Log($"���� {age}�� �Դϴ�.");
        Debug.Log($"���� Ű�� {height}cm �Դϴ�.");
        Debug.Log($"���� {gender} �Դϴ�.");
        Debug.Log($"���� MBTI�� {mbti} �Դϴ�.");
    }

    //��ư �ؽ�Ʈ ���

    /*
    ��ũ��Ʈ â�� TextMeshProUGUI, TMP_FontAsset �� ����Ƽ ���� �ִ� ����� �߰��ϴ� �� (��ũ��Ʈ�� Ŀ�����ϴ� ����)
    ����� �߰��� ��, ��ɿ� �̸��� ���̰� �Լ����� ������� ����ϴ� ����.
     */
    public TextMeshProUGUI messageText;
    public TMP_FontAsset customFont;

    private int clickCount = 0;
    public void OnClickButton()
    {
        messageText.gameObject.SetActive(true);

        if (customFont != null)
        {
            messageText.font = customFont;
        }
        if (clickCount == 0)
        {
            messageText.text = "�ϳ�";
        }
        else if (clickCount == 1)
        {
            messageText.text = "��";
        }
        else
        {
            messageText.text = "��";
        }
        clickCount++;
    }
}

