using UnityEngine;
using UnityEngine.Tilemaps;

public class Tiledis : MonoBehaviour
{
    void Awake()
    {
        GetComponent<TilemapRenderer>().enabled = false;
    }
    
}
