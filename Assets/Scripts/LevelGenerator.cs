using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class LevelGenerator : MonoBehaviour
{
    private GameObject[] rooms;

    private List<GameObject> takenPositions = new List<GameObject>();

    public int numberOfRooms = 20;
    public GameObject[] starterRooms;
    public GameObject[] middleRooms;
    public Grid mainGrid;
    public string roomTag;

    void Start()
    {

    }

    public void GenerateRooms()
    {
        SpawnStarterRoom();
    }

    public void CleanSpawnedRooms()
    {
        GameObject[] rooms = GameObject.FindGameObjectsWithTag(roomTag);
        foreach (var room in rooms)
        {
           DestroyImmediate(room); 
        }
    }

    private void SpawnStarterRoom()
    {
        int randomRoom = Random.Range(0, starterRooms.Length);
        GameObject room = Instantiate(starterRooms[randomRoom], new (0,0), Quaternion.identity);
        room.transform.parent = mainGrid.transform;
        room.GetComponent<Room>().gridPosition = new Vector2(0,0);
        takenPositions.Insert(0,room);
        Debug.Log(room.GetComponent<TilemapRenderer>().bounds.extents);

    }

    private void SpawnRooms()
    {
        // Room currentRoom = rooms[(int)worldSize.x/2, (int)worldSize.y/2].GetComponent<Room>();
        // Debug.Log(rooms[(int)worldSize.x/2, (int)worldSize.y/2].GetComponents<Renderer>().Length);

        // if(currentRoom.doorBottom)
        // {
        // }
        // if(currentRoom.doorTop)
        // {
            
        // }
        // if(currentRoom.doorLeft)
        // {
            
        // }
        // if(currentRoom.doorRight)
        // {
            
        // }
    }

    
}
