using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    string star;

    void Start()
    {
        Phase1();
        Phase2();
        Phase3();
        Phase4();
        Phase5();
    }

    public void Phase1()
    {
        star = string.Empty;

        // ������ 1

        for (int i = 0; i < 5; i++) // 5�� �ݺ���. ��.
        {
            for (int o = 0; o<i+1; o++) // i�� 5���� 1�� �����ϱ� ������ i�� ������ �ึ�� ���� �Ѱ��� �߰�. ��.
                                        // i�� �����ϴ� ����: i�� ��Ģ������ �ݺ��� ������ ��Ģ������ ��ȭ�� ����� ����. 
            {
                star += "��";
            }
            star += "\n"; // ��.
        }
        Debug.Log(star);
    }

    public void Phase2()
    {
        star = string.Empty;

        // ������ 2

        for (int i = 0; i < 5; i++) // 5�� �ݺ���. ��.
        {
            for (int o = 5; o > i + 1; o--) // 1�� ������� �� ���鸸 �߰��ߴٰ� �����ϸ� ��.
            {
                star += "��";
            }
            for (int p = 0; p < i + 1; p++) // 1�� ������� �Ȱ���.
            {
                star += "��";
            }
            star += "\n";
        }
        Debug.Log(star);
    }

    public void Phase3()
    {
        star = string.Empty;

        // ������ 3

        for (int i = 0; i < 9; i++)  // ���� 9�ٷ� �þ.
        {
            if (i>=5) // 5���� �Ǿ��� �� �ߵ�. �Ʒ���.
            {
                for (int p = 9; p > i; p--)
                {
                    star += "��";
                }
            }
            else // 5���� �ƴ϶�� 5���� ä��. ����.
            {
                for (int o = 0; o < i + 1; o++)
                {
                    star += "��";
                }
            }
            star += "\n";
        }
        Debug.Log(star);
    }

    public void Phase4()
    {
        star = string.Empty;

        // ������ 4

        for (int i = 0; i < 9; i++) // 3������� �����. ���� ������ ������ �ٲٰ� ������ ���� for���� �ϳ� �߰��� �� ����.
        {
            if (i >= 5)
            {
                for (int o = 5; o < i + 1; o++)
                {
                    star += "��";
                }
                for (int p = 10; p > i + 1; p--)
                {
                    star += "��";
                }
            }
            else
            {
                for (int a = 5; a > i + 1; a--)
                {
                    star += "��";
                }
                for (int s = 0; s < i + 1; s++)
                {
                    star += "��";
                }
            }
            star += "\n";
        }
        Debug.Log(star);
    }

    public void Phase5()
    {
        star = string.Empty;

        // ������ 5

        for (int i = 0; i < 9; i++) // 4������� �����. ���� 4/5�� �߰��� �� ����. for���� �߰��� ���� �÷��ָ� ��.
        {
            if (i >= 5)
            {
                for (int o = 5; o < i + 1; o++)
                {
                    star += "��";
                }
                for (int p = 10; p > i + 1; p--) 
                {
                    star += "��";
                }
                for (int f = 10; f > i+2; f--) // �������� �� �߰�. 3�� ������ �Ʒ��ʰ� �Ȱ���. �ݺ� ������ �ٿ� ���缭 ������.
                {
                    star += "��";
                }
            }
            else
            {
                for (int a = 5; a > i + 1; a--)
                {
                    star += "��";
                }
                for (int s = 0; s < i + 1; s++) 
                {
                    star += "��";
                }
                for (int d = 0; d < i; d++) // ������� �� �߰�. 1�� ������� �Ȱ���. �ݺ� ������ �ٿ� ���缭 ������.
                {
                    star += "��";
                }
            }
            star += "\n";
        }


        Debug.Log(star);
    }
}
