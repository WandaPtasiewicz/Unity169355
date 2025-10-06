using UnityEngine;
using UnityEditor;

[CustomEditor (typeof(PlayerController))]
public class BallEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        if(GUILayout.Button("Test"))
        {
            Debug.Log("yes");
        }
    }
}
