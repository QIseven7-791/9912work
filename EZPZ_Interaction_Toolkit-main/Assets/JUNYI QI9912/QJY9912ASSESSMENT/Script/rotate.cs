using UnityEngine;

public class rotate : MonoBehaviour
{
    public Transform targetLight;   
    public float rotateSpeed = 10f; 

    void Update()
    {
        if (targetLight != null)
        {
            targetLight.Rotate(Vector3.right * rotateSpeed * Time.deltaTime);
        }
    }
}
