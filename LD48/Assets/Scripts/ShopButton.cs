using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopButton : MonoBehaviour {
    public MiningEquipment[] equipmentInButton;
    public Image image;
    public TextMeshProUGUI text;
    private int index;
    
    void Update() {
        image.sprite = equipmentInButton[index].art;
        text.text = equipmentInButton[index].cost.ToString();
    }

    public void Buy() {
        if (FindObjectOfType<GameManager>().money >= equipmentInButton[index].cost) {
            FindObjectOfType<GameManager>().money -= equipmentInButton[index].cost;
            if (equipmentInButton[index].type == Type.PICKDRILL) {
                FindObjectOfType<GameManager>().pick = equipmentInButton[index];
                if ((equipmentInButton.Length - 1) == index && equipmentInButton[index].type != Type.ROPE) {
                    GetComponent<Button>().interactable = false;
                } else {
                    index++;
                }
            }
        }
    }
}