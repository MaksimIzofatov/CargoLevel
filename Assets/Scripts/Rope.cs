using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rope : MonoBehaviour
{
    [Range(0, 5)][SerializeField] private float _speed = 5f;
    public void OnStartMove(Vector3[] path)
    {
        StartCoroutine(MoveRope(path));
    }

    private IEnumerator MoveRope(Vector3[] path)
    {
        foreach (var point in path)
        {
            yield return StartCoroutine(MovePointToPoint(point));
        }
        
    }

    private IEnumerator MovePointToPoint(Vector3 point)
    {
        while (transform.position != point)
        {
            transform.position = Vector3.MoveTowards(transform.position, point, _speed * Time.deltaTime);
            yield return null;
        }
    }
    
    
}
