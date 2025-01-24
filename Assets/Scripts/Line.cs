using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Line : MonoBehaviour
{
    [SerializeField] private float _deep = 12.5f;
    public UnityEvent<Vector3[]> MouseButtonUp;
    private LineRenderer _renderer;
    private Camera _camera;

    private void Start()
    {
        _renderer = GetComponent<LineRenderer>();
        _camera = Camera.main;
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            DrawLine();
        }

        if (Input.GetMouseButtonUp(0))
        {
            MouseButtonUp?.Invoke(GetPathLine());
        }
    }

    private void DrawLine()
    {
        var mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, _deep);
        var position = _camera.ScreenToWorldPoint(mousePos);
        
        _renderer.positionCount++;
        _renderer.SetPosition(_renderer.positionCount - 1, position);
    }

    private Vector3[] GetPathLine()
    {
        var positions = new Vector3[_renderer.positionCount];

        _renderer.GetPositions(positions);

        return positions;
    }
}
