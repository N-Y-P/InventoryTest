using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    //ĳ���� ������ �ۼ�
    //�ʿ��� �ʵ� �� ������ �ۼ��ϱ�

    public int BaseAttack { get; private set; }//�ܺο��� �������� �ְ� ���� �������θ� ���� ����
    public int BaseDefense { get; private set; } 
    public int BaseHealth { get; private set; } 
    public int BaseCrit { get; private set; }

    //Item Ÿ���� ����Ʈ Inventory �߰�
    //���� Character�����ڿ� Inventory �߰�
    public Character(int baseAttack,  int baseDefense, int baseHealth, int baseCrit)
    {
        BaseAttack = baseAttack;
        BaseDefense = baseDefense;
        BaseHealth = baseHealth;
        BaseCrit = baseCrit;
    }

    //AddItem, Equip, UnEquip �޼��� �߰� �� ���� �ۼ�
}
