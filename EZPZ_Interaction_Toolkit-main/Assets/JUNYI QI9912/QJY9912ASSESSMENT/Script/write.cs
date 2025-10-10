using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TypeKeyToText : MonoBehaviour
{
    public string letter; // 要输入的字母
    public TMP_Text tmpText;      // TMP 文本

    void OnEnable()
    {
        if (tmpText != null)
            tmpText.text += letter;
       
    }
}