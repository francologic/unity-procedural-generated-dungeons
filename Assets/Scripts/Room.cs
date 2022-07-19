using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room
{
    public Vector2 gridPosition;
    public int type;
    public bool doorTop, doorBot,doorLeft,doorRight;
    public Room(Vector2 _gridPosition, int _type)
    {
        gridPosition = _gridPosition;
        type = _type;
    }
}
