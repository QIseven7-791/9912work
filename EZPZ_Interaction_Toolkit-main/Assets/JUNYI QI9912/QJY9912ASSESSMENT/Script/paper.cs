using UnityEngine;
using System.Collections;

public class paper : MonoBehaviour
{
    public GameObject[] objectsToShow;    
    public float showInterval = 0.5f;      

    public GameObject objectToMove;        
    public Transform moveTarget;           
    public float moveSpeed = 1f;          

    public Vector3 rotateAngle = new Vector3(0, 90, 0); 
    public float rotateSpeed = 90f;         

    private void OnEnable()
    {
        StartCoroutine(ShowObjectsSequentially());
    }

    IEnumerator ShowObjectsSequentially()
    {
        foreach (GameObject obj in objectsToShow)
        {
            obj.SetActive(true);
            yield return new WaitForSeconds(showInterval);
        }

        if (objectToMove != null && moveTarget != null)
        {
            yield return StartCoroutine(MoveObject());
            yield return StartCoroutine(RotateObject());
        }
    }

    IEnumerator MoveObject()
    {
        while (Vector3.Distance(objectToMove.transform.position, moveTarget.position) > 0.01f)
        {
            objectToMove.transform.position = Vector3.MoveTowards(
                objectToMove.transform.position,
                moveTarget.position,
                moveSpeed * Time.deltaTime
            );
            yield return null;
        }
    }

    IEnumerator RotateObject()
    {
        Quaternion startRotation = objectToMove.transform.rotation;
        Quaternion endRotation = startRotation * Quaternion.Euler(rotateAngle);
        float elapsed = 0f;
        float duration = rotateAngle.magnitude / rotateSpeed;

        while (elapsed < duration)
        {
            elapsed += Time.deltaTime;
            float t = Mathf.Clamp01(elapsed / duration);
            objectToMove.transform.rotation = Quaternion.Slerp(startRotation, endRotation, t);
            yield return null;
        }

        objectToMove.transform.rotation = endRotation;
    }
}
