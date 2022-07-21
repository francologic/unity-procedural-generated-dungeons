using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(LevelGenerator))]
public class LevelGeneratorEditor : Editor
{
    private SerializedObject m_Object;
    private SerializedProperty m_Property;
    void OnEnable() {
         m_Object = new SerializedObject(target);
     }

    public override void OnInspectorGUI()
    {
        EditorGUILayout.LabelField("Custom editor:");
        LevelGenerator myTarget = (LevelGenerator)target;
        myTarget.worldSize = EditorGUILayout.Vector2Field("World Size", myTarget.worldSize);
        EditorGUILayout.Space();
        myTarget.numberOfRooms = EditorGUILayout.IntField("Number Of Rooms", myTarget.numberOfRooms);
        EditorGUILayout.Space();
        // myTarget.starterRooms = (GameObject)EditorGUILayout.ObjectField("Starter Rooms", myTarget.starterRooms, typeof(GameObject[]), true);
        // EditorGUILayout.Space();
        m_Property = m_Object.FindProperty("starterRooms");
         EditorGUILayout.PropertyField(m_Property, new GUIContent("List of Starter Rooms"), true);
         m_Object.ApplyModifiedProperties();
        if(GUILayout.Button("Build Rooms"))
        {
            myTarget.GenerateRooms();
        }
    }
}
