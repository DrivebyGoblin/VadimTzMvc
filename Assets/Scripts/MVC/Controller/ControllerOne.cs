using UnityEngine;

public class ControllerOne : AbstractController
{
    public ControllerOne(AbstractModel model) : base(model)
    {
    }


    public override void SetItemsCount(int count)
    {
        _model.GetActiveSprites(count);
    }

}
