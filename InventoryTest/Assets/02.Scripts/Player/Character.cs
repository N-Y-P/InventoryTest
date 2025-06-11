using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Character
{
    //ĳ���� ������ �ۼ�
    //�ʿ��� �ʵ� �� ������ �ۼ��ϱ�

    public int BaseAttack { get; private set; }//�ܺο��� �������� �ְ� ���� �������θ� ���� ����
    public int BaseDefense { get; private set; } 
    public int BaseHealth { get; private set; } 
    public int BaseCrit { get; private set; }

    public int Attack => BaseAttack
                             + Inventory.Where(i => i.IsEquipped).Sum(i => i.AttackBonus);
    public int Defense => BaseDefense
                                 + Inventory.Where(i => i.IsEquipped).Sum(i => i.DefenseBonus);
    public int Health => BaseHealth
                                 + Inventory.Where(i => i.IsEquipped).Sum(i => i.HealthBonus);
    public int Crit => BaseCrit
                                 + Inventory.Where(i => i.IsEquipped).Sum(i => i.CritBonus);
    //Item Ÿ���� ����Ʈ Inventory �߰�
    public List<ItemData> Inventory { get; private set; }

    //���� Character�����ڿ� Inventory �߰�
    public Character(int baseAttack,  int baseDefense, int baseHealth, int baseCrit)
    {
        BaseAttack = baseAttack;
        BaseDefense = baseDefense;
        BaseHealth = baseHealth;
        BaseCrit = baseCrit;

        Inventory = new List<ItemData>();
    }

    //AddItem, Equip, UnEquip �޼��� �߰� �� ���� �ۼ�
    // �κ��丮�� ������ �߰�
    public void AddItem(ItemData item)
    {
        if (item == null) return;
        Inventory.Add(item);
    }

    // ���� Ŭ�� �� ����
    public void Equip(ItemData item)
    {
        if (!Inventory.Contains(item)) return;
        item.IsEquipped = true;
    }

    // ���� Ŭ�� �� ����
    public void UnEquip(ItemData item)
    {
        if (!Inventory.Contains(item)) return;
        item.IsEquipped = false;
    }
}
