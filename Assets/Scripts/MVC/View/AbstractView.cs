using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class AbstractView : MonoBehaviour
{
    [SerializeField] protected List<Image> images;
    [SerializeField] protected Text _headLineText;
    [SerializeField] protected Text _descriptionText;
    [SerializeField] protected Text _costText;
    [SerializeField] protected Image _bigIconName;
    [SerializeField] protected Button _buyButton;
    [SerializeField] protected Text _outputText;

   

    public void ShowImages(List<Sprite> _sprites)
    {
        for (int i = 0; i < _sprites.Count; i++)
        {
            images[i].sprite = _sprites[i];
        }
    }
    

    public void DisplayItems(int count)
    {
        for (int i = 0; i < count; i++)
        {
            images[i].gameObject.SetActive(true);
        }
    }

    public abstract void Init(AbstractModel model);


}
