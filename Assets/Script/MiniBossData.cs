using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class MiniBossData 
{
    public string label;
    public int pv; // ajout pv ennemis restants on stage
    public int atk;
    public int lvl;
    public float speed;
    public MiniBossCapacity miniBossCapacity; 

    [HideInInspector]
    public Types types = Types.MiniBoss; //public Types types { get; private set; } = Types.MiniBoss;
}
