using UnityEngine;


[CreateAssetMenu(fileName = "modelInfo", menuName = "Configs/ModelInfo")]
public class ModelData : ScriptableObject
{


    [SerializeField] private string _headlineText;
    public string HeadLineText { get => _headlineText; }

    [SerializeField] private string _descriptionText;
    public string DescriptionText { get => _descriptionText; }

    [SerializeField] private float _cost;
    public float Cost { get => _cost; }  

    [SerializeField] private int _discount;
    public int Discount { get => _discount; }

    [SerializeField] private string _bigIconName;
    public string BigIconName {  get => _bigIconName; }

    [SerializeField] private int _minItemsCount;
    public int MinItemsCount {  get => _minItemsCount; }

    [SerializeField] private int _maxItemsCount;
    public int MaxItemsCount {  get => _maxItemsCount; }

    [SerializeField] private string _outputInfo;
    public string OutPutInfo { get => _outputInfo; }

    private void OnValidate()
    {
        if (_discount > 100 || _discount < 1)
        {
            _discount = 1;
            Debug.LogWarning("Скидка не можеть быть больше 100% или меньше 1%");
        }
    }

}
