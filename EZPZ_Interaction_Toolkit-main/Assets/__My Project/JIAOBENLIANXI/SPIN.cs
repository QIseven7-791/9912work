using UnityEngine;

public class SPIN : MonoBehaviour
{
    public float angle;
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, Time.deltaTime*angle, 0);
    }
}
