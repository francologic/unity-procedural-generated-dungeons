using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Room : MonoBehaviour
{
    public int width;
    public int height;
    public int x;
    public int y;

    void OnDrawGizmos()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawWireCube(transform.position, new Vector3(width, height, 0));
    }

    void Start()
    {
        if(RoomController.instance == null)
        {
            throw new Exception("Non playable scene has been started");
        }

        RoomController.instance.RegisterRoom(this);
    }

    public Vector2 GetRoomCenter()
    {
        return new Vector2(x *width, y * height);
    }
}
