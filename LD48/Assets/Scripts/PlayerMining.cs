using UnityEngine;

public class PlayerMining : MonoBehaviour {
    [Header("Values")]
    public float maxMineRange;
    public GameObject currentlyOn;
    


    void Update() {
        if (Input.GetButtonDown("Fire1")) {
            if (currentlyOn != null) {
                if (Vector2.Distance(transform.position, currentlyOn.transform.position) < maxMineRange) {
                    currentlyOn.GetComponent<MinableBlock>().HitBlock();
                }
            }
        }
    }
}