using UnityEngine;
using System.Collections;

public class CameraTest : MonoBehaviour
{
    public Transform target;
    public Camera cam;

    void Start()
    {
        cam = GetComponent<Camera>();
    }

    void Update()
    {
        Vector3 screenPos = cam.WorldToScreenPoint(target.position);
        Debug.Log("target is " + screenPos.x + " pixels from the left");
    }
}