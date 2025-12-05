using UnityEngine;

public class died : MonoBehaviour
{
    public GameObject[] objectsToDestroy; 

    private void OnEnable()
    {
        foreach (GameObject obj in objectsToDestroy)
        {
            if (obj != null)
            {
                Destroy(obj);
            }
        }

        
        gameObject.SetActive(false);
    }
}
