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

        // 페이즈 1

        for (int i = 0; i < 5; i++) // 5번 반복함. 열.
        {
            for (int o = 0; o<i+1; o++) // i가 5까지 1씩 증가하기 때문에 i를 대입해 행마다 별이 한개씩 추가. 행.
                                        // i를 대입하는 이유: i가 규칙적으로 반복할 때마다 규칙적으로 변화가 생기기 때문. 
            {
                star += "★";
            }
            star += "\n"; // 열.
        }
        Debug.Log(star);
    }

    public void Phase2()
    {
        star = string.Empty;

        // 페이즈 2

        for (int i = 0; i < 5; i++) // 5번 반복함. 열.
        {
            for (int o = 5; o > i + 1; o--) // 1번 페이즈에다 이 공백만 추가했다고 생각하면 됨.
            {
                star += "　";
            }
            for (int p = 0; p < i + 1; p++) // 1번 페이즈와 똑같음.
            {
                star += "★";
            }
            star += "\n";
        }
        Debug.Log(star);
    }

    public void Phase3()
    {
        star = string.Empty;

        // 페이즈 3

        for (int i = 0; i < 9; i++)  // 열이 9줄로 늘어남.
        {
            if (i>=5) // 5줄이 되었을 때 발동. 아래쪽.
            {
                for (int p = 9; p > i; p--)
                {
                    star += "★";
                }
            }
            else // 5줄이 아니라면 5줄을 채움. 위쪽.
            {
                for (int o = 0; o < i + 1; o++)
                {
                    star += "★";
                }
            }
            star += "\n";
        }
        Debug.Log(star);
    }

    public void Phase4()
    {
        star = string.Empty;

        // 페이즈 4

        for (int i = 0; i < 9; i++) // 3페이즈랑 비슷함. 별과 공백의 형식을 바꾸고 공백이 들어가서 for문이 하나 추가된 것 뿐임.
        {
            if (i >= 5)
            {
                for (int o = 5; o < i + 1; o++)
                {
                    star += "　";
                }
                for (int p = 10; p > i + 1; p--)
                {
                    star += "★";
                }
            }
            else
            {
                for (int a = 5; a > i + 1; a--)
                {
                    star += "　";
                }
                for (int s = 0; s < i + 1; s++)
                {
                    star += "★";
                }
            }
            star += "\n";
        }
        Debug.Log(star);
    }

    public void Phase5()
    {
        star = string.Empty;

        // 페이즈 5

        for (int i = 0; i < 9; i++) // 4페이즈랑 비슷함. 행이 4/5가 추가된 것 뿐임. for문을 추가해 별을 늘려주면 끝.
        {
            if (i >= 5)
            {
                for (int o = 5; o < i + 1; o++)
                {
                    star += "　";
                }
                for (int p = 10; p > i + 1; p--) 
                {
                    star += "★";
                }
                for (int f = 10; f > i+2; f--) // 역순으로 별 추가. 3번 페이즈 아래쪽과 똑같음. 반복 조건은 줄에 맞춰서 조정함.
                {
                    star += "★";
                }
            }
            else
            {
                for (int a = 5; a > i + 1; a--)
                {
                    star += "　";
                }
                for (int s = 0; s < i + 1; s++) 
                {
                    star += "★";
                }
                for (int d = 0; d < i; d++) // 순서대로 별 추가. 1번 페이즈랑 똑같음. 반복 조건은 줄에 맞춰서 조정함.
                {
                    star += "★";
                }
            }
            star += "\n";
        }


        Debug.Log(star);
    }
}
