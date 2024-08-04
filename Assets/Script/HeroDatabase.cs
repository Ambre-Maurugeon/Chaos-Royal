using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "HeroDatabase", menuName = "Database/HeroDatabase", order = 1)]
public class HeroDatabase : ScriptableObject
{
    public List<HeroData> HeroDatas;
}


