using UnityEngine;

public enum Type {
    PICKDRILL, 
    BAG,
    ROPE
}
[CreateAssetMenu(fileName = "MiningEquipment", menuName = "ScriptableObjects/MineEquip", order = 0)]
public class MiningEquipment : ScriptableObject {
    public Sprite art;
    public Type type;
    public int cost;
    [Header("Pick/Drill")]
    public int strength;
    [Header("Bag")]
    public int holds;
}