using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SourceManager : MonoBehaviour {

    public ShowItemWindow _showItemWindow;
    private int _stoneCount = 10;
    private int _woodCount = 15;
    private int _steelCount = 25;

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

    public void AddCraftableItem(CraftableItem item)
    {
        Items.Add(item);
    }

    public void DeleteUsedSources(CraftableItemData data)
    {
        _stoneCount -= data.StoneCountToCraft;
        _woodCount -= data.WoodCountToCraft;
        _steelCount -= data.SteelCountToCraft;

        _showItemWindow.RefreshSourcePanel();
    }
}
