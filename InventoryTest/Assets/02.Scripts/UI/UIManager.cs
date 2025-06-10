using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    //3���� UI�� ����
    [SerializeField] public UIMainMenu uiMainMenu;
    [SerializeField] public UIStatus uiStatus;
    [SerializeField] public UIInventory uiInventory;

    // �ܺ� ���ٿ� ������Ƽ
    public UIMainMenu UIMainMenu => uiMainMenu;
    public UIStatus UIStatus => uiStatus;
    public UIInventory UIInventory => uiInventory;

    //�̱������� �ۼ�

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
