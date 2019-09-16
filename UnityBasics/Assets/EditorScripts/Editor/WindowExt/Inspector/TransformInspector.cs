//using System.Collections;
//using System.Collections.Generic;
//using System.Reflection;
//using UnityEditor;
//using UnityEngine;
//[CustomEditor(typeof(Transform))]
//public class TransformInspector : Editor
//{
//    private Editor m_Editor;
//    void OnEnable()
//    {
//        m_Editor = Editor.CreateEditor(target,
//            Assembly.GetAssembly(typeof(Editor)).GetType("UnityEditor.TransformInspector", true));
//    }

//    public override void OnInspectorGUI()
//    {
//        if (GUILayout.Button("拓展按钮上"))
//        {
//        }
//        //开始禁止
//        GUI.enabled = false;
//        m_Editor.OnInspectorGUI();

//        //base.OnInspectorGUI();

//        //结束禁止
//        GUI.enabled = true;
//        if (GUILayout.Button("拓展按钮下"))
//        {
//        }
//    }
//}
