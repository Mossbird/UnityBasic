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
    // 최소체력은 0

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
    public void OnClickDamage() // 데미지
    {
        Damage = Random.Range(5, 21); // 5 ~ 21

        nowHP -= Damage; // 데미지를 받는다.
        if (nowHP < 0) // 그런데 0보다 낮아지면 0으로 고정한다.
        {
            nowHP = 0;
        }

        Img_HPbar.fillAmount = nowHP / MaxHP;
        Txt_HP.text = $"{nowHP} / {MaxHP}"; // 50 / 100

        Txt_Damage.text = $"{Damage}의 피해를 입었다!";
    }

    public void OnClickHeal() // 회복
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

    //곤듀 옷 입히기
}
