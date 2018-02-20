using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftManager : MonoBehaviour {

    public CraftableItemData[] CraftableItemDatas;
    public SourceManager SourceManager;
    public ShowItemWindow ShowItemPanel;

    public GameObject BlackSwordPrefab;
    public GameObject FireHelmetPrefab;
    public GameObject GoldenGlovesPrefab;

    private int _selectedCraftableItemIndex;
    private bool _isSelectedItemCraftable;

    public void Start()
    {
        _selectedCraftableItemIndex = 0;
    }

    public void NextItem()
    {
        _selectedCraftableItemIndex++;
        if (_selectedCraftableItemIndex > CraftableItemDatas.Length - 1)
        {
            _selectedCraftableItemIndex = 0;
        }

        ShowItemPanel.RefreshCraftItemPanel(CraftableItemDatas[_selectedCraftableItemIndex]);
    }

    public void PrevItem()
    {
        _selectedCraftableItemIndex--;
        if (_selectedCraftableItemIndex < 0)
        {
            _selectedCraftableItemIndex = CraftableItemDatas.Length - 1;
        }

        ShowItemPanel.RefreshCraftItemPanel(CraftableItemDatas[_selectedCraftableItemIndex]);
    }

    public void Craft()
    {
        if (
            CraftableItemDatas[_selectedCraftableItemIndex].SteelCountToCraft <= SourceManager.GetSteelCount() &&
            CraftableItemDatas[_selectedCraftableItemIndex].StoneCountToCraft <= SourceManager.GetStoneCount() &&
            CraftableItemDatas[_selectedCraftableItemIndex].WoodCountToCraft <= SourceManager.GetWoodCount()
           )
        {
            SourceManager.DeleteUsedSources(CraftableItemDatas[_selectedCraftableItemIndex]);
            SourceManager.AddCraftableItem(GenerateItem(CraftableItemDatas[_selectedCraftableItemIndex]));
        }
        else
        {
            Debug.Log("you have not got enough resources");
        }
    }

    private CraftableItem GenerateItem(CraftableItemData craftableItemData)
    {
        GameObject source;

        switch (craftableItemData.ItemType)
        {
            case EItemType.BlackSword:
                source = BlackSwordPrefab;
                break;
            case EItemType.FireHelmet:
                source = FireHelmetPrefab;
                break;
            case EItemType.GoldenGloves:
                source = GoldenGlovesPrefab;
                break;
            default:
                source = BlackSwordPrefab;
                break;
        }

        return Instantiate(source).GetComponent<CraftableItem>();
    }
}
