using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    //3개의 UI를 연결
    [SerializeField] public UIMainMenu uiMainMenu;
    [SerializeField] public UIStatus uiStatus;
    [SerializeField] public UIInventory uiInventory;

    // 외부 접근용 프로퍼티
    public UIMainMenu UIMainMenu => uiMainMenu;
    public UIStatus UIStatus => uiStatus;
    public UIInventory UIInventory => uiInventory;

    //싱글톤으로 작성

    public static UIManager Instance;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }
}
