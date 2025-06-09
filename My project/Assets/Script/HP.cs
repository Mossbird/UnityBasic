using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HP : MonoBehaviour
{
    public Image Img_HPbar;
    public TextMeshProUGUI Txt_HP;
    public TextMeshProUGUI Txt_Damage;
    public TextMeshProUGUI Txt_Clothes;

    public int MaxHP;
    float nowHP;
    // �ּ�ü���� 0

    int Damage;
    public int HealPoint;

    void Awake()
    {
        nowHP = MaxHP;
        Initialize();
    }

    public void Initialize()
    {
        nowHP = MaxHP;
        RefreshUI();
    }
    public void OnClickDamage() // ������
    {
        Damage = Random.Range(5, 21); // 5 ~ 21

        nowHP -= Damage; // �������� �޴´�.
        if (nowHP < 0) // �׷��� 0���� �������� 0���� �����Ѵ�.
        {
            nowHP = 0;
        }

        Img_HPbar.fillAmount = nowHP / MaxHP;
        Txt_HP.text = $"{nowHP} / {MaxHP}"; // 50 / 100

        Txt_Damage.text = $"{Damage}�� ���ظ� �Ծ���!";
    }

    public void OnClickHeal() // ȸ��
    {
        nowHP += HealPoint;
        if (nowHP > MaxHP)
        {
            nowHP = MaxHP;
        }

        Img_HPbar.fillAmount = nowHP / MaxHP;
        Txt_HP.text = $"{nowHP} / {MaxHP}"; // 50 / 100
    }

    void RefreshUI()
    {
        Img_HPbar.fillAmount = nowHP / MaxHP;
        Txt_HP.text = $"{nowHP} / {MaxHP}"; // 50 / 100
    }

    //��� �� ������
}
