using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "iconsData", menuName = "Configs/iconsData")]
public class IconsData : ScriptableObject
{
    [SerializeField]
    private List<SpriteEntry> spriteEntries;
    private Dictionary<string, Sprite> spriteDict;


    private void OnEnable()
    {
        spriteDict = new Dictionary<string, Sprite>();
        foreach (var entry in spriteEntries)
        {
            entry.SetNameKeyFromSprite();
            if (!spriteDict.ContainsKey(entry.nameKey))
            {
                spriteDict.Add(entry.nameKey, entry.spriteValue);
            }
        }
    }

    public Sprite GetSprite(string name)
    {
        spriteDict.TryGetValue(name, out Sprite sprite);
        return sprite;
    }

}




[System.Serializable]
public class SpriteEntry
{
    

    public string nameKey { get; private set; }
    public Sprite spriteValue;

    public void SetNameKeyFromSprite()
    {
        if (spriteValue != null)
        {
            nameKey = spriteValue.name;
        }
    }  
    
    public SpriteEntry()
    {
        SetNameKeyFromSprite();
    }
}

    

   

