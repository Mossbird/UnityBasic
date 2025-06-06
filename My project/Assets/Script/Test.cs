using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Test : MonoBehaviour
{
    //자기 소개
    private string monsterName = "고블린";
    private int monsterAge = 15;
    private int monsterHeight = 128;
    private string monsterGender = "남성";
    private string monsterMbti = "infj";

    private void Start()
    {
        MonsterIntroduce();
        MonsterIntroduce2("오크", 19, 220, "여성", "intp");
    }

    public void MonsterIntroduce()
    {
        Debug.Log($"저의 이름은 {monsterName} 입니다.");
        Debug.Log($"저는 {monsterAge}살 입니다.");
        Debug.Log($"저의 키는 {monsterHeight}cm 입니다.");
        Debug.Log($"저는 {monsterGender} 입니다.");
        Debug.Log($"저의 MBTI는 {monsterMbti} 입니다.");
    }

    public void MonsterIntroduce2(string name, int age, int height, string gender, string mbti)
    {
        Debug.Log($"저의 이름은 {name} 입니다.");
        Debug.Log($"저는 {age}살 입니다.");
        Debug.Log($"저의 키는 {height}cm 입니다.");
        Debug.Log($"저는 {gender} 입니다.");
        Debug.Log($"저의 MBTI는 {mbti} 입니다.");
    }

    //버튼 텍스트 출력

    /*
    스크립트 창에 TextMeshProUGUI, TMP_FontAsset 등 유니티 내에 있는 기능을 추가하는 것 (스크립트를 커스텀하는 느낌)
    기능을 추가한 뒤, 기능에 이름을 붙이고 함수내에 적용시켜 사용하는 느낌.
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
            messageText.text = "하나";
        }
        else if (clickCount == 1)
        {
            messageText.text = "둘";
        }
        else
        {
            messageText.text = "셋";
        }
        clickCount++;
    }
}

