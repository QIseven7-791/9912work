using UnityEngine;

public class writerstick : MonoBehaviour
{
    public Transform target;       // 要旋转的物体
    public Vector3 axis = Vector3.right; // 旋转轴（默认X轴）
    public float angle = 30f;      // 目标角度
    public float speed = 200f;     // 旋转速度（度/秒）

    private bool goingForward = true;
    private float current = 0f;
    private Quaternion startRot;

    void OnEnable()
    {
        if (!target) target = transform;
        startRot = target.localRotation;
        current = 0f;
        goingForward = true;
    }

    void Update()
    {
        float step = speed * Time.deltaTime;
        if (goingForward)
        {
            current += step;
            if (current >= angle)
            {
                current = angle;
                goingForward = false; // 到达目标后开始回弹
            }
        }
        else
        {
            current -= step;
            if (current <= 0f)
            {
                current = 0f;
                target.localRotation = startRot;
                
                return;
            }
        }
        target.localRotation = startRot * Quaternion.AngleAxis(current, axis);
    }
}
