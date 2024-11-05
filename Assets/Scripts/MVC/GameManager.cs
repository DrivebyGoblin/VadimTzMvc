using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private NotDiscountView _notDiscountView;
    [SerializeField] private DicsountView _discountView;
    [SerializeField] private ModelData _modelData;
    [SerializeField] private IconsData _iconsData;
    [SerializeField] private bool HaveDiscount;
    [SerializeField] private CountItems _itemsCount;
    [SerializeField] private StartItems _startItems;


    private AbstractController _controller;
    private AbstractModel _model;
    

    public void Init()
    {
        _model = new ModelOne(_modelData, _iconsData);
        AbstractView viewPrefab;

        if (HaveDiscount)
            viewPrefab = _discountView;     
        else
            viewPrefab = _notDiscountView;
        

        var PlayerObject = Instantiate(viewPrefab, Vector3.zero, Quaternion.identity);
        var view = PlayerObject.GetComponent<AbstractView>();
        _controller = new ControllerOne(_model);
        _controller.SetItemsCount(_itemsCount.TakeCount());
        view.Init(_model);
        _model.GetImages(_model.Sprites, _startItems.StringsArray);
        view.ShowImages(_model.Sprites);
        view.DisplayItems(_model.SpawnItemsCount);

        
    }


}
