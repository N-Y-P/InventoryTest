using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewItem", menuName = "Inventory/Item Data")]
public class ItemData : ScriptableObject
{
    [Header("기본 정보")]
    [SerializeField] private string itemName;
    [SerializeField] private Sprite icon;

    [Header("스탯 보너스")]
    [SerializeField] private int attackBonus;
    [SerializeField] private int defenseBonus;
    [SerializeField] private int healthBonus;
    [SerializeField] private int critBonus;

    [HideInInspector] public bool IsEquipped;

    // 외부에서 읽기만 가능하도록 프로퍼티 제공
    public string ItemName => itemName;
    public Sprite Icon => icon;
    public int AttackBonus => attackBonus;
    public int DefenseBonus => defenseBonus;
    public int HealthBonus => healthBonus;
    public int CritBonus => critBonus;
}
