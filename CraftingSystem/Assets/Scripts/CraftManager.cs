using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftManager : MonoBehaviour {

    public CraftableItemData[] CraftableItemDatas;
    public SourceManager SourceManager;
    public ShowItemWindow ShowItemPanel;

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

        ShowItemPanel.Refresh(CraftableItemDatas[_selectedCraftableItemIndex]);
    }

    public void PrevItem()
    {
        _selectedCraftableItemIndex--;
        if (_selectedCraftableItemIndex < 0)
        {
            _selectedCraftableItemIndex = CraftableItemDatas.Length - 1;
        }

        ShowItemPanel.Refresh(CraftableItemDatas[_selectedCraftableItemIndex]);
    }

    public void Craft()
    {
        
    }

}
