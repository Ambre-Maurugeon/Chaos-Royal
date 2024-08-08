using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Board : MonoBehaviour
{
    [SerializeField] private List<GameObject> places;
    [SerializeField] private GameObject _prefabUnity;

    //Script
    [SerializeField]  private UnityDatabase _unityDatabase;

    [SerializeField]  private List<GameObject> takenPlaces;

    private int rd;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetRdmPlaces()
    {
        FindPosition();
    }


        

    void FindPosition()
    {
        GameObject newUnity = Instantiate(_prefabUnity);

        //Unité random
        SpriteRenderer sr = newUnity.GetComponent<SpriteRenderer>();
        sr.sprite = _unityDatabase.UnityDatas[RandomInt(0, _unityDatabase.UnityDatas.Count)].sprite;

        //Place random
        if (places.Count == 0) 
        {
            Debug.Log("Plus de places libres");
        }
        else if(places.Count == 1)
        {
            rd = 0;
        }
        else
        {
            rd = RandomInt(0, places.Count);
        }
        newUnity.transform.position = places[rd].transform.position;

        // Update places prises ou non
        takenPlaces.Add(places[rd]);
        places.Remove(places[rd]);

    }

    private int RandomInt(int a, int b)
    {
        int rd = Random.Range(a, b);
        Debug.Log("c'est le rd " + rd);
        return rd;
    }

    private void UpdateFreePlaces()
    {
        foreach (GameObject place in takenPlaces)
        {
            // verifier si ca contient un pivot
            //si non{}
        }
    }

}
