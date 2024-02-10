using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UIElements;

public class TileManager : MonoBehaviour
{
    [SerializeField] private Tilemap _interactableMap;
    [SerializeField] private Tile _hiddenInteractableTile;
    [SerializeField] private Tile[] _interactedTile;
    void Start()
    {        
        foreach (var position in _interactableMap.cellBounds.allPositionsWithin)
        {
            TileBase tile = _interactableMap.GetTile(position);
            if (tile != null && tile.name == "interact_visible")
            {
                _interactableMap.SetTile(position, _hiddenInteractableTile);
            }
        }
    }

    public bool IsInteractable(Vector2 position)
    {
        Vector3Int gridPosition = _interactableMap.WorldToCell(position);
        TileBase tile = _interactableMap.GetTile(gridPosition);
        if (tile != null && tile.name == "interact")
        {
            return true;
        }
        return false;
    }

    public void SetInteracted(Vector3 position)
    {
        Vector3Int gridPosition = _interactableMap.WorldToCell(position);
        int randCell = Random.Range(0, _interactedTile.Length);
        _interactableMap.SetTile(gridPosition, _interactedTile[randCell]);
    }
}
