using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


using UnityEngine;

public class OverrideInspector: MonoBehaviour
{
    /// Add a context menu named "Do Something" in the inspector
    /// of the attached script.
    [ContextMenu("Do Something")]
    void DoSomething()
    {
        Debug.Log("Perform operation");
    }

    [ContextMenu("Remove Component")]
    void RemoveComponent()
    {
        DestroyImmediate(this);
    }

}
