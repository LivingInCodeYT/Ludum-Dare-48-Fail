using UnityEngine;

public class GenerateBlocks : MonoBehaviour {
    public GameObject block;

    void Start() {
        for (float x = -8.604f; x < 10.604f; x += 2) {
            for (float y = -6f; y > -10; y -= 1.999f) {
                Instantiate(block, new Vector2(x, y), Quaternion.identity);
            }
        }
    }
}