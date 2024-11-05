

public class NotDiscountView : AbstractView
{
    public override void Init(AbstractModel model)
    {
        _headLineText.text = model.HeadLineText;
        _descriptionText.text = model.DescriptionText;
        _costText.text = model.Cost.ToString() + "$";
        _bigIconName.sprite = model.GetBigImage();
        _outputText.text = model.WindowOutputData;
    }
}
