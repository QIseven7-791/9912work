using UnityEngine;

public class Door : MonoBehaviour
{
    public float TargetAngle = 90f;         
    public float RotateSpeed = 90f;        
    public bool OpenDoor = false;       

    private bool OpeningDoor = false;
    private Quaternion InitialAngle;
    private Quaternion Targetrotation;

    void Start()
    {
        InitialAngle = transform.rotation;
        Targetrotation = InitialAngle * Quaternion.Euler(0, TargetAngle, 0);

        if (OpenDoor)
            OpeningDoor = true;
    }

    void Update()
    {
        if (OpeningDoor)
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Targetrotation, RotateSpeed * Time.deltaTime);

            if (Quaternion.Angle(transform.rotation, Targetrotation) < 0.1f)
                OpeningDoor = false;
        }
    }

    public void Opendoor()
    {
        OpeningDoor = true;
    }
}
