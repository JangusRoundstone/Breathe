using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMazeSetup : MonoBehaviour
{
    public static Transform ballTransform;

    public static List<Vector2Int> wormholes = new List<Vector2Int>();

    public static int[,] map;

    public float spacing = 1.1f;

    public Transform gridHolder;

    public GameObject tilePrefab;
    
    public GameObject blockPrefab;

    public GameObject ballPrefab;

    public GameObject goalPrefab;

    public GameObject wormholePrefab;

    public GameObject endUI;

    // Start is called before the first frame update
    void Start()
    {
        map = new int[5,6]
        {
            {0, 3, 0, 0, 0, 4},  // Goal = 4, Wormhole = 3, Ball = 2, Block = 1
            {0, 1, 0, 1, 1, 1},
            {0, 0, 0, 0, 0, 0},  
            {0, 1, 1, 1, 1, 0},
            {0, 0, 3, 0, 0, 2}    
        };

        for(int col = 0; col < 5; col++)
        {
            for(int row = 0; row < 6; row++)
            {
                Vector3 tilePosition = new Vector3(col * spacing, 0, row * spacing);
                Instantiate(tilePrefab, tilePosition, Quaternion.identity, gridHolder);
            }
        }

        for(int row = 0; row < 5; row++)
        {
            for(int col = 0; col < 6; col++)
            {
                if (map[row, col] == 1)
                {
                    Vector3 blockPosition = new Vector3(row * spacing, 0.125f, col * spacing);
                    Instantiate(blockPrefab, blockPosition, Quaternion.identity, gridHolder);
                }
                else if(map[row, col] == 2)
                {
                    Vector3 ballPosition = new Vector3(row * spacing, 0.5f, col * spacing);
                    GameObject ball = Instantiate(ballPrefab, ballPosition, Quaternion.identity, gridHolder);
                    ballTransform = ball.transform;
                    ball.GetComponent<BallMovement>().UpdateGridPos(new Vector2Int(row, col));
                    ball.GetComponent<BallMovement>().setUI(endUI);
                }
                else if(map[row, col] == 3)
                {
                    Vector3 wormholePosition = new Vector3(row * spacing, 0.125f, col * spacing);
                    Instantiate(wormholePrefab, wormholePosition, Quaternion.identity, gridHolder);
                    wormholes.Add(new Vector2Int(row, col));
                }
                else if(map[row, col] == 4)
                {
                    Vector3 goalPosition = new Vector3(row * spacing, 0.5f, col * spacing);
                    Instantiate(goalPrefab, goalPosition, Quaternion.identity, gridHolder);
                }
            }
        }
    }
}
