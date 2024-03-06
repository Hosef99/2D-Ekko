using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;


public enum TileType{
    None,
    Block,
    Floor,
    Door,
    Interact
}

public class Tile
{
    public Vector3 position;
    public GameObject[] gameObjects;
    public TileType tileType;
    public bool stepable = false;
    public bool movable = false;
    public bool interactable = false;

    public bool IsTile(TileType compTileType){
        if (compTileType == tileType){
            return true;
        }
        return false;
    }


}
