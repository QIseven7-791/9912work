using UnityEngine;

public class ink : MonoBehaviour
{
    public Vector3 upOffset = new Vector3(0f, 0.2f, 0f);
    public Vector3 leftOffset = new Vector3(-0.2f, 0f, 0f);
    public float moveSpeed = 1f;
    public float waitTime = 1f;

    private Vector3 originalPos;
    private Vector3 targetPos;
    private int step = 0;
    private bool isMoving = false;

    void Start()
    {
        originalPos = transform.position;
        targetPos = originalPos + upOffset;
        isMoving = true;
    }

    void Update()
    {
        if (!isMoving) return;

        transform.position = Vector3.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);

        if (Vector3.Distance(transform.position, targetPos) < 0.001f)
        {
            isMoving = false;
            step++;
            Invoke("SetNextTarget", waitTime);
        }
    }

    void SetNextTarget()
    {
        if (step == 1)
            targetPos = originalPos + upOffset + leftOffset;
        else if (step == 2)
            targetPos = originalPos;
        else
            return;

        isMoving = true;
    }
}
