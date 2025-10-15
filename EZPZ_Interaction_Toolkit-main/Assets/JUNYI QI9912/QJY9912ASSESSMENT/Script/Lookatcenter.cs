using UnityEngine;

public class LookAtCenter : MonoBehaviour
{
    public Transform center; // Բ������

    [ContextMenu("����Բ��")]
    void LookToCenter()
    {
        if (center == null)
        {
            Debug.LogWarning("����Inspector������Բ�����壡");
            return;
        }
        transform.LookAt(center.position);
    }
}
