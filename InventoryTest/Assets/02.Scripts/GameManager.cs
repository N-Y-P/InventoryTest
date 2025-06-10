using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //player 프로퍼티 추가
    public Character player {  get; private set; }
    //SetData()메서드 만들기
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

        // UIManager의 uiStatus를 통해 화면에 반영
        UIManager.Instance.uiStatus.SetStatus(player);
    }
}
