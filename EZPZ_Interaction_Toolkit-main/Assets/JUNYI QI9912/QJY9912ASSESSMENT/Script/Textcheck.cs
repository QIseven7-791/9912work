using UnityEngine;
using TMPro; // 如果你用的是 TextMeshPro

public class Textcheck : MonoBehaviour
{
    public TMP_Text textBox;  // 绑定 TMP 文本框

    [System.Serializable]
    public class TriggerRule
    {
        public string keyword;              // 检测关键字
        public GameObject[] targetObjects;  // 多个目标物体
        public bool setActive;              // 要设置的显示状态
    }

    public TriggerRule[] rules;

    private string lastText = "";

    void Update()
    {
        if (textBox == null) return;

        string currentText = textBox.text;

        // 文本变动时执行检查
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
