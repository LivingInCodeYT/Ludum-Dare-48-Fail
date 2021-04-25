using UnityEngine;

public class Shop : MonoBehaviour {
    public float distanceToInteractable;
    public GameObject toolTip;
    public GameObject shopUI;

    void Update() {
        Transform p = GameObject.FindGameObjectWithTag("Player").transform;
        if (Vector2.Distance(p.position, transform.position) < distanceToInteractable) {
            toolTip.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E)) {
                if (shopUI.activeInHierarchy) {
                    shopUI.SetActive(false);
                } else {
                    shopUI.SetActive(true);
                }
            }
        } else {
            toolTip.SetActive(false);
            shopUI.SetActive(false);
        }
    }

}
