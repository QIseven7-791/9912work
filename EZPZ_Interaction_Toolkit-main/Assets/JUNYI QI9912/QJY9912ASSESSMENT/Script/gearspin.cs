using UnityEngine;

public class gearspin : MonoBehaviour
{
    public Transform target;             
    public Vector3 gearangle = new Vector3(15f, 0, 0);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnEnable()
    {
        if (!target) target = transform;
        target.localRotation *= Quaternion.Euler(gearangle);
    }
}

