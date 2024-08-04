using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MiniBossDatabase", menuName = "Database/MiniBossDatabase", order = 1)]
public class MiniBossDatabase : ScriptableObject
{
    public List<MiniBossData> MiniBossDatas;
}
