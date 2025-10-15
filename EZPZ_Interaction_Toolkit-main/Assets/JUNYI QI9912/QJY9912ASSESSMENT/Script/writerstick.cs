using UnityEngine;

public class writerstick : MonoBehaviour
{
    public Transform target;       
    public Vector3 axis = Vector3.right; 
    public float angle = 30f;      
    public float speed = 200f;     

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
                goingForward = false; 
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
