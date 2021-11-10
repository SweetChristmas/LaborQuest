using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Location", menuName = "Entities/Location", order = 0)]
public class Location : ScriptableObject
{
    new public string name;
    public Skill skill;
    public List<Drop> drops;
}
