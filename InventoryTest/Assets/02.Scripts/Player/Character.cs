using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    //캐릭터 데이터 작성
    //필요한 필드 및 생성자 작성하기

    public int BaseAttack { get; private set; }//외부에서 읽을수만 있고 내부 로직으로만 변경 가능
    public int BaseDefense { get; private set; } 
    public int BaseHealth { get; private set; } 
    public int BaseCrit { get; private set; }

    //Item 타입의 리스트 Inventory 추가
    public List<Item> Inventory { get; private set; }

    //추후 Character생성자에 Inventory 추가
    public Character(int baseAttack,  int baseDefense, int baseHealth, int baseCrit)
    {
        BaseAttack = baseAttack;
        BaseDefense = baseDefense;
        BaseHealth = baseHealth;
        BaseCrit = baseCrit;

        Inventory = new List<Item>();
    }

    //AddItem, Equip, UnEquip 메서드 추가 및 내용 작성
    // 인벤토리에 아이템 추가
    public void AddItem(Item item)
    {
        if (item == null) return;
        Inventory.Add(item);
    }

    // 슬롯 클릭 시 장착
    public void Equip(Item item)
    {
        if (!Inventory.Contains(item)) return;
        item.IsEquipped = true;
    }

    // 슬롯 클릭 시 해제
    public void UnEquip(Item item)
    {
        if (!Inventory.Contains(item)) return;
        item.IsEquipped = false;
    }
}
