using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    //���� �ʵ� �� ������Ƽ, ������ �ۼ�
    public string Name { get; }
    public Sprite Icon { get; }
    public int AttackBonus { get; }
    public int DefenseBonus { get; }
    public int HealthBonus { get; }
    public int CritBonus { get; }
    public bool IsEquipped { get; set; }

    public Item(string name, Sprite icon, int attackBonus, int defenseBonus, int healthBonus, int critBonus, bool isEquiped)
    {
        Name = name;
        Icon = icon;
        AttackBonus = attackBonus;
        DefenseBonus = defenseBonus;
        HealthBonus = healthBonus;
        CritBonus = critBonus;
        IsEquipped = isEquiped;
    }
}
