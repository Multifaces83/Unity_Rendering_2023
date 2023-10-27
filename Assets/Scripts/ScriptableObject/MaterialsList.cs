using UnityEngine;
using System;

[CreateAssetMenu(fileName = "MaterialsList", menuName = "ScriptableObjects/MaterialsList", order = 1)]
public class MaterialsList : ScriptableObject
{
    public MaterialChoice[] materials;
}

[Serializable]
public class MaterialChoice
{
    public string name;
    public Sprite sprite;
    public string description;
    public Material material;
}

