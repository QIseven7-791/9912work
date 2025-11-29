using UnityEngine;

public class NPCwalk : MonoBehaviour
{
    public Transform target;  
    public float speed = 2f;   

    void Update()
    {
        if (target == null) return;

        // 移动方向
        Vector3 direction = (target.position - transform.position).normalized;

        // 移动位置
        transform.position += direction * speed * Time.deltaTime;
    }
}
