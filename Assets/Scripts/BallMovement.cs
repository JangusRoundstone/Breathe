using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float spacing = 1.1f;

    private GameObject endUI;

    private Vector2Int gridPos;

    private List<GameObject> oldTiles = new List<GameObject>();

    private float[] targetFrequencies = { 18f, 16f, 12f, 9f }; // desired blinking frequencies for SSVEP stimuli

    void Start()
    {
        if (endUI == null)
            endUI = GameObject.Find("EndUI"); 
        EvaluateTiles(gridPos, BallMazeSetup.map);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) 
            TryMove(Vector2Int.up);
        else if (Input.GetKeyDown(KeyCode.DownArrow)) 
            TryMove(Vector2Int.down);
        else if (Input.GetKeyDown(KeyCode.RightArrow)) 
            TryMove(Vector2Int.right);
        else if (Input.GetKeyDown(KeyCode.LeftArrow)) 
            TryMove(Vector2Int.left);
    }

    public void TryMove(Vector2Int dir)
    {
        DeactiveTiles(oldTiles); // First remove SSVEP stimuli from all existing tiles
        oldTiles.Clear();

        Vector2Int newPos = gridPos + dir;
        if (newPos.x < 0 || newPos.x >= 5 || newPos.y < 0 || newPos.y >= 6)
        {
            EvaluateTiles(gridPos, BallMazeSetup.map);
            return;
        }

        int tileValue = BallMazeSetup.map[newPos.x, newPos.y];
        if (tileValue == 0 || tileValue == 2)
        {
            transform.position = new Vector3(newPos.x * spacing, 0.5f, newPos.y * spacing);
            gridPos = newPos;
        }
        else if (tileValue == 3)
        {
            if (newPos == BallMazeSetup.wormholes[0])
            {
                teleport(new Vector3(BallMazeSetup.wormholes[1].x * spacing, 0.5f, BallMazeSetup.wormholes[1].y * spacing));
                gridPos = BallMazeSetup.wormholes[1];
            }
            else
            {
                teleport(new Vector3(BallMazeSetup.wormholes[0].x * spacing, 0.5f, BallMazeSetup.wormholes[0].y * spacing));
                gridPos = BallMazeSetup.wormholes[0];
            }
        }
        else if (tileValue == 4)
        {
            endUI.SetActive(true);
        }
        EvaluateTiles(gridPos, BallMazeSetup.map);
    }

    private void DeactiveTiles(List<GameObject> oldTiles)
    {
        foreach (GameObject tile in oldTiles)
        {
            tile.GetComponent<FlickerTileMaterial>().enabled = false;
            tile.GetComponent<FlickerTileMaterial>().ResetTileColor();
        }
    }

    private void EvaluateTiles(Vector2Int gridPos, int[,] map)
    {
        int freqIndex = 0;
        if ((gridPos.x + 1) < 5 && map[gridPos.x + 1, gridPos.y] != 1)
        {
            SSVEP(new Vector2Int(gridPos.x + 1, gridPos.y), targetFrequencies[freqIndex]);
            freqIndex++;
        }
        if ((gridPos.x - 1) >= 0 && map[gridPos.x - 1, gridPos.y] != 1)
        {
            SSVEP(new Vector2Int(gridPos.x - 1, gridPos.y), targetFrequencies[freqIndex]);
            freqIndex++;
        }
        if ((gridPos.y + 1) < 6 && map[gridPos.x, gridPos.y + 1] != 1)
        {
            SSVEP(new Vector2Int(gridPos.x, gridPos.y + 1), targetFrequencies[freqIndex]);
            freqIndex++;
        }
        if ((gridPos.y - 1) >= 0 && map[gridPos.x, gridPos.y - 1] != 1)
        {
            SSVEP(new Vector2Int(gridPos.x, gridPos.y - 1), targetFrequencies[freqIndex]);
        }
    }

    private void SSVEP(Vector2Int gridPos, float targetFrequency)
    {
        Vector3 tileWorldPos = new Vector3(gridPos.x * spacing, 0, gridPos.y * spacing); 
        Collider[] hits = Physics.OverlapSphere(tileWorldPos, 0.1f);
        foreach (Collider i in hits)
        {
            if (i.CompareTag("Tile")) // Activate and flicker the tile at desired frequency
            {
                FlickerTileMaterial script = i.gameObject.GetComponent<FlickerTileMaterial>();
                script.SetFrequency(targetFrequency); 
                script.enabled = true;
                oldTiles.Add(i.gameObject);
                break;
            }
        }
    }

    public void UpdateGridPos(Vector2Int Pos)
    {
        gridPos = Pos;
    }

    public void teleport(Vector3 Pos)
    {
        transform.position = Pos;
    }

    public void setUI(GameObject ui)
    {
        endUI = ui;
    }
}
