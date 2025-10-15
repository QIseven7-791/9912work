using UnityEngine;

public class writerstick : MonoBehaviour
{
    public Transform target;       // Ҫ��ת������
    public Vector3 axis = Vector3.right; // ��ת�ᣨĬ��X�ᣩ
    public float angle = 30f;      // Ŀ��Ƕ�
    public float speed = 200f;     // ��ת�ٶȣ���/�룩

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
                goingForward = false; // ����Ŀ���ʼ�ص�
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
