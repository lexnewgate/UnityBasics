using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

namespace Assets.Editor.WindowExt.Hierarchy
{
    class HierarchyItemOnGUI
    {
        [InitializeOnLoadMethod]
        static void InitializeOnLoadMethod()
        {
            EditorApplication.hierarchyWindowItemOnGUI = delegate (int instanceID, Rect selectionRect) {
                //在Hierarchy视图中选择一个资源
                if (Selection.activeObject &&
                    instanceID == Selection.activeObject.GetInstanceID())
                {
                    //设置拓展按钮区域
                    float width = 50f;
                    float height = 20f;
                    selectionRect.x += (selectionRect.width - width);
                    selectionRect.width = width;
                    selectionRect.height = height;
                    //点击事件
                    if (GUI.Button(selectionRect, AssetDatabase.LoadAssetAtPath<Texture>("Assets/unity.png")))
                    {
                        Debug.LogFormat("click : {0}", Selection.activeObject.name);
                    }
                }
            };
        }
    }
}
