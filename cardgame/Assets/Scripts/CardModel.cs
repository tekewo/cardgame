using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//カードデータ
public class CardModel
{
    public string name;
    public int hp;
    public int atk;
    public int cost;

    public Sprite icon;

    public CardModel(int cardID)
    {
        CardEntity cardEntity = Resources.Load<CardEntity>("CardEntityList/Card"+cardID);
        name = cardEntity.name;
        hp = cardEntity.hp;
        atk = cardEntity.atk;
        cost = cardEntity.cost;
        icon = cardEntity.icon;
    }

}
