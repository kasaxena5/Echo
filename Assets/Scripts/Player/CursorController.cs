using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorController : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;

    private void Awake()
    {
        Cursor.visible = false;
    }

    void FixedUpdate()
    {
        Vector2 position = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        transform.position = position;
    }
}
