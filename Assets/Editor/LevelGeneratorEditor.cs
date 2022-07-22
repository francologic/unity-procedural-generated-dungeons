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
        EditorGUILayout.Space();
        myTarget.numberOfRooms = EditorGUILayout.IntField("Number Of Rooms", myTarget.numberOfRooms);
        EditorGUILayout.Space();
        myTarget.roomTag = EditorGUILayout.TextField("Room's tag name", myTarget.roomTag);
        EditorGUILayout.Space();
        myTarget.mainGrid = (Grid)EditorGUILayout.ObjectField("Main Grid", myTarget.mainGrid, typeof(Grid), true);
        EditorGUILayout.Space();
        m_Property = m_Object.FindProperty("starterRooms");
         EditorGUILayout.PropertyField(m_Property, new GUIContent("List of Starter Rooms"), true);
         m_Object.ApplyModifiedProperties();
        m_Property = m_Object.FindProperty("middleRooms");
         EditorGUILayout.PropertyField(m_Property, new GUIContent("List of Middle Rooms"), true);
         m_Object.ApplyModifiedProperties();
        if(GUILayout.Button("Build Rooms"))
        {
            myTarget.GenerateRooms();
        }
        EditorGUILayout.Space();
        if(GUILayout.Button("Clean Rooms"))
        {
            myTarget.CleanSpawnedRooms();
        }
    }
}
