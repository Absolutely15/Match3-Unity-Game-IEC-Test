using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemSkin", menuName = "ScriptableObjects/ItemSkin")]
public class ItemSkin : ScriptableObject
{
    public List<Skin> skinType;
}

public enum SkinType
{
    FRUIT,
    FISH
}

[Serializable]
public class Skin
{
    public List<Sprite> skinData;
    
}
