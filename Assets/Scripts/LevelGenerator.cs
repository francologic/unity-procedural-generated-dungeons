using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public Vector2 worldSize = new(5, 5);
    private Room[,] rooms;

    private List<Vector2> takenPositions = new List<Vector2>();

    public int numberOfRooms = 20;
    public GameObject[] starterRooms;
    public Grid mainGrid;
    public string roomTag;

    void Start()
    {

    }

    public void GenerateRooms()
    {
        SpawnStarterRoom();
    }

    private void SpawnStarterRoom()
    {
        Vector2 worldCenter = new (worldSize.x/2, worldSize.y/2);
        int randomRoom = Random.Range(0, starterRooms.Length);
        GameObject room = Instantiate(starterRooms[randomRoom], worldCenter, Quaternion.identity);
        room.transform.parent = mainGrid.transform;
    }

    public void CleanSpawnedRooms()
    {
        GameObject[] rooms = GameObject.FindGameObjectsWithTag(roomTag);
        foreach (var room in rooms)
        {
           DestroyImmediate(room); 
        }
    }
}
