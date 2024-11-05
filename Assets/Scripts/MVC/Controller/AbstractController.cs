using UnityEngine;

public abstract class AbstractController
{
    protected AbstractModel _model; 

    protected AbstractController(AbstractModel model)
    {
        _model = model;
    }
    public abstract void SetItemsCount(int count);

}
