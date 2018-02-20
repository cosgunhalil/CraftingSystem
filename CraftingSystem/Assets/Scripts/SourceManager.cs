using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SourceManager : MonoBehaviour {

    private int _stoneCount;
    private int _woodCount;
    private int _steelCount;

    public List<CraftableItem> Items;

    public void SetStoneCount(int stoneCount)
    {
        _stoneCount = stoneCount;
    }

    public int GetStoneCount()
    {
        return _stoneCount;
    }

    public void SetWoodCount(int woodCount)
    {
        _woodCount = woodCount;
    }

    public int GetWoodCount()
    {
        return _woodCount;
    }

    public void SetSteelCount(int steelCount)
    {
        _steelCount = steelCount;
    }

    public int GetSteelCount()
    {
        return _steelCount;
    }
}
