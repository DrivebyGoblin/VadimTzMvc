using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StartItems : MonoBehaviour
{
    [SerializeField] private CountItems _itemsCount;
    [SerializeField] private GameObject _startMenuBtn;

    [SerializeField] private TMP_InputField inputField;


    public List<string> StringsArray { get => inputList; }
    private List<string> inputList = new List<string>();
    private int maxInputs; 

    void Start()
    {
        maxInputs = _itemsCount.TakeCount();
        inputField.onEndEdit.AddListener(HandleInput);
    }

    void HandleInput(string input)
    {
        if (inputList.Count < maxInputs && !string.IsNullOrEmpty(input))
        {
            inputList.Add(input);
            inputField.text = string.Empty;
        }


        if (inputList.Count >= maxInputs)
        {
            List<string> filledList = GetFilledList();
            inputField.gameObject.SetActive(false);
            _startMenuBtn.gameObject.SetActive(true);


        }
    }

    public List<string> GetFilledList()
    {
        return inputList;
    }



}
