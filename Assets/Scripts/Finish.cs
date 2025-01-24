using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    [SerializeField] private Rope _rope;
    [SerializeField] private BoxController _box;
    [SerializeField] private Transform _endPoint;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Rope"))
        {
            _rope.Stop();
            _box.DropDown(_endPoint.position);
        }
    }
}
