using UnityEngine;
using TMPro;

public class Textdelete : MonoBehaviour
{
    public TMP_Text textBox; 
    private void OnEnable()
    {
        if (textBox != null && textBox.text.Length > 0)
        {
            textBox.text = textBox.text.Substring(0, textBox.text.Length - 1);
        }

       
        gameObject.SetActive(false);
    }
}
