using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Bounds : MonoBehaviour
{
    [Header("¹ã²¥")]
    public BoundEventSO BoundEvent;
    private void Start()
    {
        BoundEvent.BoundRaiseEvent(gameObject.GetComponent<Collider2D>());
    }
}
