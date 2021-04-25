using UnityEngine;

public class MinableBlock : MonoBehaviour {
    private int health = 5;
    public bool hasOre;

    void Start() {
        hasOre = (Random.value > 0.5f);
    }
    public void HitBlock() {
        health -= GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>().GetPickStrength();
        FindObjectOfType<AudioManager>().Play("BlockHit");
        if (health <= 0) {
            //Block ded
            FindObjectOfType<AudioManager>().Play("BlockDestroy");
            Instantiate(GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>().GetParticle(Particles.BLOCKDESTROY), transform.position, Quaternion.identity);
            FindObjectOfType<PlayerMining>().currentlyOn = null;
            Destroy(gameObject);
        }
    }
    void OnMouseOver() {
        FindObjectOfType<PlayerMining>().currentlyOn = gameObject;
    }
    void OnMouseExit() {
        FindObjectOfType<PlayerMining>().currentlyOn = null;
    }
}