using System.Collections;
using UnityEngine;

public class npctypewriter : MonoBehaviour
{
    public GameObject[] objectsToActivate; // 拖入需要依次显示的物体
    public float interval = 1f;            // 每个物体之间的显示时间间隔（秒）
    public bool autoStart = true;          // 是否自动开始

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
