using UnityEngine;

public enum Particles {
    BLOCKDESTROY
}


public class GameManager : MonoBehaviour {
    public MiningEquipment pick;
    [Header("Particles")]
    public GameObject blockDestroy;
    public int money;


    public int GetPickStrength() {
        return pick.strength;
    }
    public GameObject GetParticle(Particles _particle) {
        switch (_particle) {
            case Particles.BLOCKDESTROY:
                return blockDestroy;
            break;
        }
        return null;
    }
}