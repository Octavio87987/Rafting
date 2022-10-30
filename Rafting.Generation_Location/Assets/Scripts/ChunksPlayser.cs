using System.Collections.Generic;
using UnityEngine;

public class ChunksPlayser : MonoBehaviour
{
    public Transform Player;
    public Chunk[] ChunkPrefabs;
    public Chunk FirstChunk;

    private List<Chunk> spawnedChunks = new List<Chunk>();

    public void Start()
    {
        spawnedChunks.Add(FirstChunk);
    }


    public void Update()
    {
        if (Player.position.z < spawnedChunks[spawnedChunks.Count- 1].Begin.position.z) 
        {
            SpawnChunk();
        }
    }

    private void SpawnChunk()
    {
        Chunk newChunk =  Instantiate(ChunkPrefabs[Random.Range(0, ChunkPrefabs.Length)]);
        newChunk.transform.position = spawnedChunks[spawnedChunks.Count - 1].End.position - newChunk.Begin.localPosition;

        spawnedChunks.Add(newChunk);
    }
    
}
