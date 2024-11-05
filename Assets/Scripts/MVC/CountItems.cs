using UnityEngine;
using UnityEngine.UI;

public class CountItems : MonoBehaviour
{
    private InputField _field;
    private int _itemsCount;
    public int ItemsCount { get => _itemsCount; }

    [SerializeField] private ModelData _data;

    
    void Start()
    {
        _field = GetComponent<InputField>();
        _field.onValueChanged.AddListener(OnValueChanged);
    }

    private void OnValueChanged(string input)
    {
        if (int.TryParse(input, out int number))
        {
            if (number < _data.MinItemsCount || number > _data.MaxItemsCount)
            {
                _field.text = "";
                Debug.LogWarning($"Значение должно быть от {_data.MinItemsCount} до {_data.MaxItemsCount}");
            }
        }
        else
        {
            _field.text = "";
        }

        _field.MoveTextEnd(false);
    }

    public int TakeCount()
    {

        if (int.TryParse(_field.text, out _itemsCount))
        {
            return _itemsCount;
        }
        else
        {
            return default;
        }

    }

}