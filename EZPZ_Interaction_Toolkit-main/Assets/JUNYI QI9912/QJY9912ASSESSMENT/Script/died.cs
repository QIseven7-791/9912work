using UnityEngine;

public class died : MonoBehaviour
{
    public GameObject[] objectsToDestroy; // 拖入你要销毁的物体列表

    private void OnEnable()
    {
        foreach (GameObject obj in objectsToDestroy)
        {
            if (obj != null)
            {
                Destroy(obj);
            }
        }

        // 自身设为 false，避免二次触发
        gameObject.SetActive(false);
    }
}
