using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "UnityDatabase", menuName = "Database/UnityDatabase", order = 1)]
public class UnityDatabase : ScriptableObject
{
    public List<UnityData> UnityDatas;
}
