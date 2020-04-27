using UnityEngine;

[CreateAssetMenu(fileName = "StatData", menuName = "ScriptableObjects/CharacterScriptableObject", order = 1)]
public class CharacterScriptableObject : ScriptableObject
{
    public int ID;

    public Mesh characterMesh;

    public int offense, agility, defence;
    public string characterDescription;
}
