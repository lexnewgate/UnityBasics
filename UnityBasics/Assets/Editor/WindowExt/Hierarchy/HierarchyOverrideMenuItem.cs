using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class HierarchyOverrideMenuItem : MonoBehaviour
{
    //[MenuItem("GameObject/UI/Image")] //the trick is override same item
    //static void CreatImage()
    //{
    //    if (Selection.activeTransform)
    //    {
    //        if (Selection.activeTransform.GetComponentInParent<Canvas>())
    //        {
    //            Image image = new GameObject("image").AddComponent<Image>();
    //            image.raycastTarget = false;
    //            image.transform.SetParent(Selection.activeTransform, false);
    //            //设置选中状态
    //            Selection.activeTransform = image.transform;
    //        }
    //    }
    //}
}
