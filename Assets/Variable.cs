using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variable : MonoBehaviour
{
    public string Name = "��ȣ��";
    public string address= "����� ���빮��";

    // [SerializeField] �����̳ʿ� ������ �� ���� ��
    int money = 11700;

    //���� ����
    public int num = 2022;
    //�¾ ����
    public int num2 = 1997;

    //type

    void Start()
    {
        //������ ���� �����ʹ� void Start�� �Է��Ѵ�.
        int num3 = (num - num2 + 1);

        Debug.Log("�ȳ��ϼ���^_^");
        Debug.Log("?(*�ơ��*)??(*�ơ��*)?");
        Debug.Log("���� " + Name + " �Դϴ�.");
        Debug.Log("���� " + address + "�� �ֽ��ϴ�.");

        Debug.Log("���峻��");
        Debug.Log("�̸� :" + Name);
        Debug.Log("������ : " + address);
        Debug.Log("�ܾ� : 0");
        Debug.Log("���� : " + num3);
        

    }
}
