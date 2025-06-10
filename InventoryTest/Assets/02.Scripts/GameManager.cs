using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //player ������Ƽ �߰�
    public Character player {  get; private set; }
    //SetData()�޼��� �����
    private void Start()
    {
        SetData();
    }

    public void SetData()
    {
        player = new Character(
            baseAttack: 35,
            baseDefense: 40,
            baseHealth: 100,
            baseCrit: 25
        );

        // UIManager�� uiStatus�� ���� ȭ�鿡 �ݿ�
        UIManager.Instance.uiStatus.SetStatus(player);
    }
}
