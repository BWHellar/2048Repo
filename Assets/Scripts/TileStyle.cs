using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class TileStyleInfo
{
    public int Number;
    public Color32 TileColor;
    public Color32 TextColor;
}

public class TileStyle : MonoBehaviour
{

    public static TileStyle Instance;

    public TileStyleInfo[] TileStyleInfos;
    
    void Awake()
    {
        Instance = this;
    }

}
