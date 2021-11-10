using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Drop", menuName = "Entities/Drop", order = 0)]
public class Drop : ScriptableObject
{
    public Item item;
    public float chance;

}
