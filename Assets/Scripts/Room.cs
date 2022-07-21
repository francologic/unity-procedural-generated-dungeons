using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Room", menuName ="Room")]
public class Room: ScriptableObject
{
    public Vector2 gridPosition;
    public bool doorTop, doorBot,doorLeft,doorRight;
    public Room(Vector2 _gridPosition)
    {
        gridPosition = _gridPosition;
    }
}
