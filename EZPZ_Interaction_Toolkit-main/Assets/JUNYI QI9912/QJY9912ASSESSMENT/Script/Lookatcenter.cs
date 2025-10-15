using UnityEngine;

public class LookAtCenter : MonoBehaviour
{
    public Transform center; // 圆心物体

    [ContextMenu("朝向圆心")]
    void LookToCenter()
    {
        if (center == null)
        {
            Debug.LogWarning("请在Inspector里拖入圆心物体！");
            return;
        }
        transform.LookAt(center.position);
    }
}
