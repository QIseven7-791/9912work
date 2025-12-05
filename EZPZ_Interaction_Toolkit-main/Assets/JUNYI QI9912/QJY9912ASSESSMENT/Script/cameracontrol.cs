using UnityEngine;

public class cameracontrol : MonoBehaviour
{
    public Camera mainCamera;       
    public float targetFOV = 30f;    
    public float zoomSpeed = 20f;    

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

    public float originalFOV = 60f; 
    public void ResetZoom()
    {
        mainCamera.fieldOfView = originalFOV;
        isZooming = false;
    }

}
