using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Parctice : MonoBehaviour
{
    public TextMeshProUGUI Text_result;
    string[] characterA = { "각청", "모나", "치치" };
    public void GotchaSystem()
    {
        Text_result.text = "";
        int count = 0;

        for (int i = 0; i < 10; i++)
        {
            int randomValue = Random.Range(1, 101);
            string selected = "";

            if (8 <= count) // 각청 천장
            {
                selected = characterA[0]; 
                count = 0;
            }
            else if (randomValue <= 10) // 각청
            {
                selected = characterA[0];
                count = 0;
            }

            else if (randomValue <= 40) // 모나
            {
                selected = characterA[1];
                count++;
            }

            else // 치치
            {
                selected = characterA[2];
                count++;
            }

            Debug.Log($"랜덤 값: {randomValue} 뽑은 캐릭터: {selected}");
            Text_result.text += $"{selected} 를 뽑았습니다!\n";
        }
    }
}
