using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class HierarchyMenuItems 
{
    [MenuItem("GameObject/My Create/Cube", false, 0)]
    static void CreateCube()
    {
        GameObject.CreatePrimitive(PrimitiveType.Cube); //创建立方体
    }
}
