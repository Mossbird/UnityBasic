using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlFlow : MonoBehaviour
{

    int count;

    private void Awake()
    {
        count = 0;
    }
    void Start()
    {
    }
    public void Gacha()
    {
        for (int i = 0; i < 10; i++)
        {
            int randomValue = Random.Range(1, 101);
            Debug.Log($"���� ���� {randomValue} �Դϴ�.");
            if (8 <= count)
            {
                Debug.Log("��û�� �̾Ҵ�!!!");
                count = 0;
            }
            else if (randomValue <= 10)
            {
                Debug.Log("��û�� �̾Ҵ�!!!");
                count = 0;
            }
            else if (randomValue <= 30)
            {
                Debug.Log("�𳪸� �̾Ҵ�!");
            }
            else
            {
                Debug.Log("ġġ�� �̾Ҵ�...");
            }
            count++;
        }
    }

    public void GachaSwitch()
    {
        // 
        int randomValue = Random.Range(1, 101); // 1�̻� 101�̸��� ������ ���� �޾� ���ڴ�. (1 ~ 100) 

        int selectNumbe = 0;

        switch (selectNumbe)
        {
            case 0:
                // ���� �Ӹ� ĳ���Ͱ� ���´�
                {
                    if (randomValue <= 10) // 1 ~ 10 -> 10%
                    {
                        Debug.Log("'���� �Ӹ�'�� �̾Ҵ�!");
                    }
                    else if (randomValue <= 30) // 11 ~ 30
                    {
                        Debug.Log("'��'�� �̾Ҵ�!");
                    }
                    else
                    {
                        Debug.Log("'ġġ'�� �̾ƹ��ȴ�!");
                    }
                }
                break;

            case 1:
                // �Ķ� �Ӹ� ĳ���Ͱ� ���´�
                {
                    if (randomValue <= 10) // 1 ~ 10 -> 10%
                    {
                        Debug.Log("'�Ķ� �Ӹ�'�� �̾Ҵ�!");
                    }
                    else if (randomValue <= 30) // 11 ~ 30
                    {
                        Debug.Log("'��'�� �̾Ҵ�!");
                    }
                }
                break;
        }
    }

}