using System.Collections.Generic;
using UnityEngine;

public class ItemSkinChanger : MonoBehaviour
{
    [SerializeField] private ItemSkin itemSkin;
    [SerializeField] private List<SpriteRenderer> itemSkinList;
    private void Start()
    {
        ChangeSkinType(SkinType.FISH);
    }

    private void ChangeSkinType(SkinType skinType) => ChangeSkinType((int)skinType);
    private void ChangeSkinType(int skinType)
    {
        for (var i = 0; i < itemSkinList.Count; i++)
        {
            itemSkinList[i].sprite = itemSkin.skinType[skinType].skinData[i];
        }
    }
}
