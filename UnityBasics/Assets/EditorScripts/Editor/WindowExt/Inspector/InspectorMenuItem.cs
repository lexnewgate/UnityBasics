using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class InspectorMenuItem : MonoBehaviour
{
    [MenuItem("CONTEXT/Transform/New Context 1")]
    public static void NewContext1(MenuCommand command)
    {
        //获取对象名
        Debug.Log(command.context.name);
    }
    [MenuItem("CONTEXT/Component/New Context 2")]
    public static void NewContext2(MenuCommand command)
    {
        Debug.Log(command.context.name);
    }
}
