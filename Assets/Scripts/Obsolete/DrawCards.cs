using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawCards : MonoBehaviour
{

  //  public GameObject card1;
  //  public GameObject card2;
    public GameObject playerArea;
    public GameObject enemyArea;

    public GameObject[] cardsArray;

  //  List<GameObject> cards = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
  //      cards.Add(card1);
  //      cards.Add(card2);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnClick()
    {
        for (var i = 0; i < 5; i++)
        { 
            // Populate the player cards
            GameObject playerCard = Instantiate(cardsArray[Random.Range(0, cardsArray.Length)], new Vector3(0, 0, 0), Quaternion.identity);
            playerCard.transform.SetParent(playerArea.transform, false);


            //Populate the oppositions cards
            GameObject enemyCard = Instantiate(cardsArray[Random.Range(0, cardsArray.Length)], new Vector3(0, 0, 0), Quaternion.Euler(0, 0, -180));
            enemyCard.transform.SetParent(enemyArea.transform, false);
        }
    }
}
