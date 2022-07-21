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

    void Start()
    {

    }

    public void GenerateRooms()
    {
        Debug.Log("AAAA");
    }

    private void spawnStarterRoom()
    {

    }
}
