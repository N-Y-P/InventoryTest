using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewItem", menuName = "Inventory/Item Data")]
public class ItemData : ScriptableObject
{
    [Header("�⺻ ����")]
    [SerializeField] private string itemName;
    [SerializeField] private Sprite icon;

    [Header("���� ���ʽ�")]
    [SerializeField] private int attackBonus;
    [SerializeField] private int defenseBonus;
    [SerializeField] private int healthBonus;
    [SerializeField] private int critBonus;

    [HideInInspector] public bool IsEquipped;

    // �ܺο��� �б⸸ �����ϵ��� ������Ƽ ����
    public string ItemName => itemName;
    public Sprite Icon => icon;
    public int AttackBonus => attackBonus;
    public int DefenseBonus => defenseBonus;
    public int HealthBonus => healthBonus;
    public int CritBonus => critBonus;
}
