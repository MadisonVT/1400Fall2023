using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    public object Value { get; set; }
    public FloatData floatData;
    public GameObject gameObject;

    public void OnTriggerEnter(Collider other)
    {
        AddHealth();
        Destroy(gameObject);
    }

    public void AddHealth()
    {
        floatData.UpdateValue(Value.Set);
    }
}
