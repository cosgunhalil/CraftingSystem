using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowItemWindow : MonoBehaviour {

    public SourceManager _sourceManager;

    public TextMeshProUGUI WoodSourceText;
    public TextMeshProUGUI StoneSourceText;
    public TextMeshProUGUI SteelSourceText;

    public TextMeshProUGUI WoodCraftText;
    public TextMeshProUGUI StoneCraftText;
    public TextMeshProUGUI SteelCraftText;
    public TextMeshProUGUI CurrentCraftableItemName;

    public void RefreshCraftItemPanel(CraftableItemData data)
    {
        CurrentCraftableItemName.text = data.ItemType.ToString();
        WoodCraftText.text = data.WoodCountToCraft.ToString();
        StoneCraftText.text = data.StoneCountToCraft.ToString();
        SteelCraftText.text = data.SteelCountToCraft.ToString();

    }

    public void RefreshSourcePanel()
    {
        WoodSourceText.text = _sourceManager.GetWoodCount().ToString();
        StoneSourceText.text = _sourceManager.GetStoneCount().ToString();
        SteelSourceText.text = _sourceManager.GetSteelCount().ToString();
    }

}
