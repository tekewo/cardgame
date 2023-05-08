using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // create hands
    [SerializeField] Transform playerHandTransform;
    [SerializeField] CardController cardprefab;
    void Start()
    {
        CreateCard(playerHandTransform);
    }

    void CreateCard(Transform hand)
    {
        CardController card = Instantiate(cardprefab, hand, false);
        card.Init(2);
    }
}
