using System.Collections;
using System.Collections.Generic;
using Com.LuisPedroFonseca.ProCamera2D;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private ProCamera2D proCamera;

    void Start()
    {
        proCamera = Camera.main.GetComponent<ProCamera2D>();

        // Tìm player theo tag
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            proCamera.AddCameraTarget(player.transform);
        }
    }
}
