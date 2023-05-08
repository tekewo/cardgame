using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardView : MonoBehaviour
{
    [SerializeField] TMPro.TMP_Text nameText;
    [SerializeField] TMPro.TMP_Text hpText;
    [SerializeField] TMPro.TMP_Text atkText;
    [SerializeField] TMPro.TMP_Text costText;
    [SerializeField] Image iconImage;

    public void Show(CardModel cardModel)
    {
        nameText.text = cardModel.name; 
        hpText.text = cardModel.hp.ToString(); 
        atkText.text = cardModel.atk.ToString(); 
        costText.text = cardModel.cost.ToString(); 
        iconImage.sprite = cardModel.icon;
    }


}
