using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIStatus : MonoBehaviour
{
    //�Ϻ� UI ������ҿ� �ش��ϴ� �ʵ��� �߰�
    public TextMeshProUGUI attackText;
    public TextMeshProUGUI defenseText;
    public TextMeshProUGUI healthText;
    public TextMeshProUGUI critText;

    //Character ������ �����ϴ� �޼��� �߰�(���� ���ڿ� Ȱ��)
    public void SetStatus(Character character)
    {
        attackText.text = $"{character.Attack}";
        defenseText.text = $"{character.Defense}";
        healthText.text = $"{character.Health}";
        critText.text = $"{character.Crit}";
    }
}
