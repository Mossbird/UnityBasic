using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Parctice : MonoBehaviour
{
    public TextMeshProUGUI Text_result;
    string[] characterA = { "��û", "��", "ġġ" };
    public void GotchaSystem()
    {
        Text_result.text = "";
        int count = 0;

        for (int i = 0; i < 10; i++)
        {
            int randomValue = Random.Range(1, 101);
            string selected = "";

            if (8 <= count) // ��û õ��
            {
                selected = characterA[0]; 
                count = 0;
            }
            else if (randomValue <= 10) // ��û
            {
                selected = characterA[0];
                count = 0;
            }

            else if (randomValue <= 40) // ��
            {
                selected = characterA[1];
                count++;
            }

            else // ġġ
            {
                selected = characterA[2];
                count++;
            }

            Debug.Log($"���� ��: {randomValue} ���� ĳ����: {selected}");
            Text_result.text += $"{selected} �� �̾ҽ��ϴ�!\n";
        }
    }
}
