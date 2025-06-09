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
            Debug.Log($"랜덤 값은 {randomValue} 입니다.");
            if (8 <= count)
            {
                Debug.Log("각청을 뽑았다!!!");
                count = 0;
            }
            else if (randomValue <= 10)
            {
                Debug.Log("각청을 뽑았다!!!");
                count = 0;
            }
            else if (randomValue <= 30)
            {
                Debug.Log("모나를 뽑았다!");
            }
            else
            {
                Debug.Log("치치을 뽑았다...");
            }
            count++;
        }
    }

    public void GachaSwitch()
    {
        // 
        int randomValue = Random.Range(1, 101); // 1이상 101미만의 랜덤한 값을 받아 오겠다. (1 ~ 100) 

        int selectNumbe = 0;

        switch (selectNumbe)
        {
            case 0:
                // 은색 머리 캐릭터가 나온다
                {
                    if (randomValue <= 10) // 1 ~ 10 -> 10%
                    {
                        Debug.Log("'은색 머리'을 뽑았다!");
                    }
                    else if (randomValue <= 30) // 11 ~ 30
                    {
                        Debug.Log("'모나'을 뽑았다!");
                    }
                    else
                    {
                        Debug.Log("'치치'를 뽑아버렸다!");
                    }
                }
                break;

            case 1:
                // 파란 머리 캐릭터가 나온다
                {
                    if (randomValue <= 10) // 1 ~ 10 -> 10%
                    {
                        Debug.Log("'파란 머리'을 뽑았다!");
                    }
                    else if (randomValue <= 30) // 11 ~ 30
                    {
                        Debug.Log("'모나'을 뽑았다!");
                    }
                }
                break;
        }
    }

}