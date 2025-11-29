using UnityEngine;

public class HR : MonoBehaviour
{
    [Header("True object")]
    public GameObject[] objectsToActivate;

    [Header("Hide object")]
    public GameObject[] objectsToDeactivate;

    [Header("One time ")]
    public bool oneTimeTrigger = true;

    private bool triggered = false;

    void OnTriggerEnter(Collider other)
    {
        if (triggered && oneTimeTrigger) return;

        if (other.CompareTag("Player")) 
        {
            foreach (GameObject obj in objectsToActivate)
            {
                if (obj != null)
                    obj.SetActive(true);
            }

            foreach (GameObject obj in objectsToDeactivate)
            {
                if (obj != null)
                    obj.SetActive(false);
            }

            triggered = true;
        }
    }
}
