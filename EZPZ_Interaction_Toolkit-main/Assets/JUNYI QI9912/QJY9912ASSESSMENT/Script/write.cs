using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TypeKeyToText : MonoBehaviour
{
    public string letter;
    public TMP_Text tmpText;   

    void OnEnable()
    {
        if (tmpText != null)
            tmpText.text += letter;
       
    }
}