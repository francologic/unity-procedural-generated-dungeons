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

    public Door leftDoor;
    public Door rightDoor;
    public Door topDoor;
    public Door bottomDoor;
    public List<Door> doors = new List<Door>();

    void OnDrawGizmos()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawWireCube(transform.position, new Vector3(width, height, 0));
    }

    void Start()
    {
        if (RoomController.instance == null)
        {
            throw new Exception("Non playable scene has been started");
        }

        Door[] ds = GetComponentsInChildren<Door>();
        foreach (Door d in ds)
        {
            doors.Add(d);
            switch (d.doorType)
            {
                case Door.DoorType.right:
                    rightDoor = d;
                    break;
                case Door.DoorType.left:
                    leftDoor = d;
                    break;
                case Door.DoorType.top:
                    topDoor = d;
                    break;
                case Door.DoorType.bottom:
                    bottomDoor = d;
                    break;
            }
        }

        RoomController.instance.RegisterRoom(this);
    }

    // public void RemoveUnconnectedDoors()
    // {
    //     foreach (Door door in doors)
    //     {
    //         switch (door.doorType)
    //         {
    //             case Door.DoorType.right:
    //                 rightDoor = d;
    //                 break;
    //             case Door.DoorType.left:
    //                 leftDoor = d;
    //                 break;
    //             case Door.DoorType.top:
    //                 topDoor = d;
    //                 break;
    //             case Door.DoorType.bottom:
    //                 bottomDoor = d;
    //                 break;
    //         }
    //     }
    // }

    // public Room GetRight()
    // {
        
    // }
    // public Room GetLeft()
    // {

    // }
    // public Room GetTop()
    // {

    // }
    // public Room GetBottom()
    // {

    // }

    public Vector2 GetRoomCenter()
    {
        return new Vector2(x * width, y * height);
    }
}
