using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatHandler : MonoBehaviour
{
    GameObject activePanel;
    bool isDragging = false;

    void Update()
    {
        if (isDragging)
        {
            UpdatePanelPosition();
        }
    }

    public void SetDraggingState(GameObject panel, bool dragging)
    {
        if (dragging)
        {
            activePanel = panel;
            Vector3 mPos = Input.mousePosition;
        }
        else
        {
        }
        isDragging = dragging;
    }

    void UpdatePanelPosition()
    {
        if (activePanel != null)
        {
            Vector3 mPos = Input.mousePosition;
            activePanel.transform.position = new Vector3(((int)Mathf.Floor(mPos.x) * 0.01f) - 9.61f, ((int)Mathf.Floor(mPos.y) * 0.01f) - 5.2f, 0);
        }
    }
}
