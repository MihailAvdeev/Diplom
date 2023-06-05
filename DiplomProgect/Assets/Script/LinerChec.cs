using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinerChec : MonoBehaviour
{
    public Camera camera;
    LineRenderer lineRenderer;
    Vector3 mousePos;
    bool isMousePressed;
    public GameObject[] worlds;
    public int score;

    void Start()
    {
        lineRenderer = gameObject.AddComponent<LineRenderer>();
        lineRenderer.positionCount = 2;
        lineRenderer.startWidth = 0.1f;
        lineRenderer.endWidth = 0.1f;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isMousePressed = true;
            lineRenderer.positionCount = 0;
        }

        if (Input.GetMouseButtonUp(0))
        {
            isMousePressed = false;
        }

        if (isMousePressed)
        {
            mousePos = camera.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 0;
            lineRenderer.positionCount++;
            lineRenderer.SetPosition(lineRenderer.positionCount - 1, mousePos);
        }
        Debug.Log(score);
    }

}
