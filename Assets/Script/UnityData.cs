using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class UnityData 
{
    public string label;
    public int pv; // ajout pv ennemis restants on stage
    public int atk;
    public int lvl;
    public Sprite sprite;



    [HideInInspector]
    public Types types = Types.MiniBoss; //public Types types { get; private set; } = Types.MiniBoss;
}
