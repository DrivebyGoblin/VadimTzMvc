using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractModel
{



    protected ModelData _modelData;
    protected IconsData _iconsData;

    protected List<Sprite> _sprites = new List<Sprite>();

    public List<Sprite> Sprites { get => _sprites; }

    protected AbstractModel(ModelData modelData, IconsData iconsData)
    {
        _iconsData = iconsData;
        _modelData = modelData;
        _headlineText = modelData.HeadLineText;
        _descriptionText = modelData.DescriptionText;
        _cost = modelData.Cost;
        _discount = modelData.Discount;
        _bigIconName = modelData.BigIconName;
        _windowOutputData = modelData.OutPutInfo;
    }


    public void GetActiveSprites(int count)
    {
        _spawnItemsCount = count;
    }


    public void GetImages(List<Sprite> list, List<string> _stringsArray)
    {
        for (int i = 0; i < SpawnItemsCount; i++)
        {
            _sprites.Add(_iconsData.GetSprite(_stringsArray[i]));
        }
    }



    public Sprite GetBigImage()
    {
       var x = _iconsData.GetSprite(_modelData.BigIconName);
       return x;
    }



    public float CalculateOldCost(float oldCost, int percent)
    {
        float discountPercentage = percent;
        var discountAmount = oldCost * (discountPercentage / 100);
        var newCost = oldCost - discountAmount;
        return newCost;
    }

    protected string _headlineText;
    public string HeadLineText { get => _headlineText; }

    protected string _descriptionText;
    public string DescriptionText { get => _descriptionText; }

    protected float _cost;
    public float Cost { get => _cost; }

    protected int _discount;
    public int Discount { get => _discount; }

    protected float _oldCost;
    public float OldCost { get => _oldCost; }

    protected string _bigIconName;
    public string BigIconName { get => _bigIconName; }

    protected int _minItemsCount;
    public int MinItemsCount { get => _minItemsCount; }

    protected int _spawnItemsCount;
    public int SpawnItemsCount { get => _spawnItemsCount; }

    protected int _maxItemsCount;
    public int MaxItemsCount { get => _maxItemsCount; }

    protected bool _haveDiscount;
    public bool HaveDiscount { get => _haveDiscount; }

    protected string _windowOutputData;
    public string WindowOutputData { get => _windowOutputData; }
}
