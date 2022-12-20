using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variable : MonoBehaviour
{
    public string Name = "김호영";
    public string address= "서울시 서대문구";

    // [SerializeField] 디자이너와 소통할 때 쓰는 것
    int money = 11700;

    //올해 연도
    public int num = 2022;
    //태어난 연도
    public int num2 = 1997;

    //type

    void Start()
    {
        //계산식이 들어가는 데이터는 void Start에 입력한다.
        int num3 = (num - num2 + 1);

        Debug.Log("안녕하세요^_^");
        Debug.Log("?(*°▽°*)??(*°▽°*)?");
        Debug.Log("저는 " + Name + " 입니다.");
        Debug.Log("저는 " + address + "에 있습니다.");

        Debug.Log("통장내역");
        Debug.Log("이름 :" + Name);
        Debug.Log("거주지 : " + address);
        Debug.Log("잔액 : 0");
        Debug.Log("나이 : " + num3);
        

    }
}
