using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Data/CraftableItemData")]
public class CraftableItemData : ScriptableObject {

    public EItemType ItemType;
    public int WoodCountToCraft;
    public int StoneCountToCraft;
    public int SteelCountToCraft;

}

public enum EItemType
{
    BlackSword,
    FireHelmet,
    GoldenGloves
}
