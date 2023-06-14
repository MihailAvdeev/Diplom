using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Letter : MonoBehaviour
{
    public string letter;

    private bool connected = false;
    private LineRenderer lineRenderer;
    private GameObject connectedTo;

    private void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }
    public bool IsConnected()
    {
        return connected;
    }
    public void SetConnected(GameObject connectTo)
    {
        connected = true;
        connectedTo = connectTo;
    }
    private void OnMouseDown()
    {
        if (!connected)
        {
            foreach (Transform letterObj in transform.parent)
            {
                Letter otherLetter = letterObj.GetComponent<Letter>();
                if (otherLetter != this && !otherLetter.IsConnected())
                {
                    float distance = Vector2.Distance(transform.position, otherLetter.transform.position);
                    if (distance < 0.5f)
                    {
                        // соединяем буквы линией
                        lineRenderer.SetPosition(0, transform.position);
                        lineRenderer.SetPosition(1, otherLetter.transform.position);

                        connected = true;
                        connectedTo = otherLetter.gameObject;
                        otherLetter.SetConnected(this.gameObject);
                        break;
                    }
                }
            }
        }
    }
}

