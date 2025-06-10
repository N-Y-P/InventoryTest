using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIStatus : MonoBehaviour
{
    //하부 UI 구성요소에 해당하는 필드모두 추가
    public TextMeshProUGUI attackText;
    public TextMeshProUGUI defenseText;
    public TextMeshProUGUI healthText;
    public TextMeshProUGUI critText;

    //Character 정보를 세팅하는 메서드 추가(보간 문자열 활용)
    public void SetStatus(Character character)
    {
        attackText.text = $"{character.Attack}";
        defenseText.text = $"{character.Defense}";
        healthText.text = $"{character.Health}";
        critText.text = $"{character.Crit}";
    }
}
