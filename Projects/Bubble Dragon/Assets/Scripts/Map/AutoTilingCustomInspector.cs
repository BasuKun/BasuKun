using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(AutoTiling))]
public class AutoTilingCustomInspector : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        AutoTiling autoTiling = (AutoTiling)target;

        if (GUILayout.Button("GENERATE TILES"))
        {
            autoTiling.AutoTile();
        }
    }
}
