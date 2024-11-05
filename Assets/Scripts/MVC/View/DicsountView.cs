using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DicsountView : AbstractView
{
    [SerializeField] protected Text _discount;
    [SerializeField] protected TextMeshProUGUI oldCost;
    [SerializeField] protected GameObject _discountBlock;

    public override void Init(AbstractModel model)
    {
        _headLineText.text = model.HeadLineText;
        _descriptionText.text = model.DescriptionText;
        _discount.text = "-" + model.Discount.ToString() + "%";
        oldCost.text = model.Cost.ToString() + "$";
        _costText.text = model.CalculateOldCost(model.Cost, model.Discount).ToString() + "$";
        _bigIconName.sprite = model.GetBigImage();
        _outputText.text = model.WindowOutputData;
    }
}
