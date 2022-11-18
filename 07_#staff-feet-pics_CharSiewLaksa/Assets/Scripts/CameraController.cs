using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class CameraController : MonoBehaviour
{
    public void ToggleCamera()
    {
        if (VuforiaBehaviour.Instance.enabled)
        {
            VuforiaBehaviour.Instance.VideoBackground.StopVideoBackgroundRendering();
            VuforiaBehaviour.Instance.enabled = false;
        }
        else
        {
            VuforiaBehaviour.Instance.VideoBackground.StartVideoBackgroundRendering();
            VuforiaBehaviour.Instance.enabled = true;
        }
    }
}
