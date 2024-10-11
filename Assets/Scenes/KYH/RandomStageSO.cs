using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewSO",menuName = "SO/GameSquencing")]
public class RandomStageSO : ScriptableObject
{
    public GameObject sequencing;
    public float Time;
    public int textNum;
}
