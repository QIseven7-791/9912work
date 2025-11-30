using UnityEngine;

public class cameracontrol : MonoBehaviour
{
    public Camera mainCamera;        // 拖拽你的 Main Camera
    public float targetFOV = 30f;    // 最终要缩小到的视野范围
    public float zoomSpeed = 20f;    // 缩放速度

    private bool isZooming = false;

    void Update()
    {
        if (isZooming)
        {
            float currentFOV = mainCamera.fieldOfView;
            if (currentFOV > targetFOV)
            {
                mainCamera.fieldOfView -= zoomSpeed * Time.deltaTime;
            }
        }
    }

    public void StartZoom()
    {
        isZooming = true;
    }

    public float originalFOV = 60f;  // 恢复到默认视野
    public void ResetZoom()
    {
        mainCamera.fieldOfView = originalFOV;
        isZooming = false;
    }

}
