using System.Collections;
using UnityEngine;

public class npctypewriter : MonoBehaviour
{
    public GameObject[] objectsToActivate; 
    public float interval = 1f;           
    public bool autoStart = true;          

    void Start()
    {
        if (autoStart)
        {
            StartCoroutine(ActivateSequentially());
        }
    }

    public void StartActivation()
    {
        StartCoroutine(ActivateSequentially());
    }

    IEnumerator ActivateSequentially()
    {
        foreach (GameObject obj in objectsToActivate)
        {
            obj.SetActive(true);
            yield return new WaitForSeconds(interval);
        }
    }
}
