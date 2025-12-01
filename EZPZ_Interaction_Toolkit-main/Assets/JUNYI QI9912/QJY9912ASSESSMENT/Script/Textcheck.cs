using UnityEngine;
using TMPro; 

public class Textcheck : MonoBehaviour
{
    public TMP_Text textBox; 

    [System.Serializable]
    public class TriggerRule
    {
        public string keyword;              
        public GameObject[] targetObjects;  
        public bool setActive;              
    }

    public TriggerRule[] rules;

    private string lastText = "";

    void Update()
    {
        if (textBox == null) return;

        string currentText = textBox.text;

        
        if (currentText != lastText)
        {
            lastText = currentText;
            CheckRules(currentText);
        }
    }

    void CheckRules(string content)
    {
        foreach (TriggerRule rule in rules)
        {
            if (content.Contains(rule.keyword))
            {
                foreach (GameObject obj in rule.targetObjects)
                {
                    if (obj != null)
                        obj.SetActive(rule.setActive);
                }
            }
        }
    }
}
