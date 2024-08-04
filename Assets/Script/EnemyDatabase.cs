using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyDatabase", menuName = "Database/EnemyDatabase", order = 1)]
public class EnemyDatabase : ScriptableObject
{
    public List<EnemyData> EnemyDatas;
}
