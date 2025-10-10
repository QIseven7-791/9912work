using UnityEngine;

public class keyboard : MonoBehaviour
{
    public Transform target;
    public Vector3 startPosition;  
    public Vector3 sinOffset;      
    public float alpha;            
    public float sinValue;         
    public float rangeFactor;      
    public float keySpeed;         

    void Start()
    {
        startPosition = target.localPosition;
        alpha = 0f;
    }

    void Update()
    {
        if (alpha >= 180f)
        {
            target.localPosition = startPosition; 
            enabled = false;
            alpha = 0f;
            sinOffset = Vector3.zero;
            enabled = gameObject.activeInHierarchy;
            gameObject.SetActive(false);
            return;
        }
        sinValue = -Mathf.Abs(Mathf.Sin(alpha * Mathf.Deg2Rad));      
        sinOffset.y = sinValue * rangeFactor;
        target.localPosition = startPosition + sinOffset;
        alpha += keySpeed * Time.deltaTime;

      

    }
}

