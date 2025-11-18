using UnityEngine;
using TMPro;

public class TypewriterAutoLine : MonoBehaviour
{
    public TextMeshProUGUI Text;  
    public int maxCharsPerLine = 25;      
    private string fullText = "";        

    public void TypeCharacter(char c)
    {
        fullText += c;

        
        string formatted = "";
        for (int i = 0; i < fullText.Length; i++)
        {
            if (i > 0 && i % maxCharsPerLine == 0)
            {
                formatted += "\n"; 
            }
            formatted += fullText[i];
        }

        Text.text = formatted;
    }
}
