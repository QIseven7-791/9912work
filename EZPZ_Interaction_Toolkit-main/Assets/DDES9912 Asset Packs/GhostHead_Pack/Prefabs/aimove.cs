using UnityEngine;

public class aimove : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Rigidbody Rb;
    public Transform target;
    public float speed;


    // Start is called before the first frame update
    public void Start()
    {
        target = GameObject.Find("player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);



    }
}
