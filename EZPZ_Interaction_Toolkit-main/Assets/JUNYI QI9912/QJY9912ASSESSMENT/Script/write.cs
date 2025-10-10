using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TypeKeyToText : MonoBehaviour
{
    public string letter; // Ҫ�������ĸ
    public TMP_Text tmpText;      // TMP �ı�

    void OnEnable()
    {
        if (tmpText != null)
            tmpText.text += letter;
       
    }
}