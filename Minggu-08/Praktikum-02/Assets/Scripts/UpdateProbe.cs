using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateProbe : MonoBehaviour
{
    private ReflectionProbe probe;

    void Awake()
    {
        probe = GetComponent<ReflectionProbe>();
        probe.RenderProbe();
    }
    public void RefreshProbe()
    {
        probe.RenderProbe();
    }
}

