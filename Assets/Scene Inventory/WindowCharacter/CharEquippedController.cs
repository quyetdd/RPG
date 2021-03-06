using UnityEngine;
using System.Collections;

public class CharEquippedController : MonoBehaviour {

    public GameObject _LeftLeg;
    public GameObject _RightLeg;

    public GameObject _LeftArm;
    public GameObject _RightArm;

    public GameObject[] itens = new GameObject[4];


	void Start () {
        _LeftArm.GetComponent<ItemSlotController>().itemTypeSlot = ItemType.Equipment;
        _LeftLeg.GetComponent<ItemSlotController>().itemTypeSlot = ItemType.Equipment;
        _RightArm.GetComponent<ItemSlotController>().itemTypeSlot = ItemType.Equipment;
        _RightLeg.GetComponent<ItemSlotController>().itemTypeSlot = ItemType.Equipment;

        _LeftArm.GetComponent<ItemSlotController>().equipTypeSlot = EquipmentType.LeftArm;
        _LeftLeg.GetComponent<ItemSlotController>().equipTypeSlot = EquipmentType.LeftLeg;
        _RightArm.GetComponent<ItemSlotController>().equipTypeSlot = EquipmentType.RightArm;
        _RightLeg.GetComponent<ItemSlotController>().equipTypeSlot = EquipmentType.RightLeg;

        for (int i = 0; i < itens.Length; i++)
        {
            itens[i].GetComponent<ItemSlotController>().itemTypeSlot = ItemType.Alchemy;
        }

	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ClearEquipment()
    {
        _LeftLeg.GetComponent<ItemSlotController>().removeItem();
        _RightLeg.GetComponent<ItemSlotController>().removeItem();
        _LeftArm.GetComponent<ItemSlotController>().removeItem();
        _RightArm.GetComponent<ItemSlotController>().removeItem();

        for (int i = 0; i < itens.Length; i++)
        {
            itens[i].GetComponent<ItemSlotController>().removeItem();
        }

    }

    public void UpdateCharDetail()
    {
        ClearEquipment();

        for (int i = 0; i < 4; i++)
        {
            if (GlobalCharacter.player.itens[i] != null)
            {
                addItem(GlobalCharacter.player.itens[i], i);
            }
        }

        if (GlobalCharacter.player.leftArm != null)
        {
            addEquipment(GlobalCharacter.player.leftArm);
        }
        if (GlobalCharacter.player.rightArm != null)
        {
            addEquipment(GlobalCharacter.player.rightArm);
        }
        if (GlobalCharacter.player.leftLeg != null)
        {
            addEquipment(GlobalCharacter.player.leftLeg);
        }
        if (GlobalCharacter.player.rightLeg != null)
        {
            addEquipment(GlobalCharacter.player.rightLeg);
        }
    }

    public void addItem(GameItem item, int pos)
    {
        ItemSlotController slot = itens[pos].GetComponent<ItemSlotController>();
        if (!slot.hasItem)
        {
            slot.addToSlot(item);
        }
    }

    public void addEquipment(GameItem equipment)
    {
        GameObject itm = null;
        switch (equipment.equipmentType)
        {
            case EquipmentType.LeftArm:
                itm = _LeftArm;
                break;
            case EquipmentType.LeftLeg:
                itm = _LeftLeg;
                break;
            case EquipmentType.RightArm:
                itm = _RightArm;
                break;
            case EquipmentType.RightLeg:
                itm = _RightLeg;
                break;
        }

        ItemSlotController gamItm = itm.GetComponent<ItemSlotController>();
        gamItm.addToSlot(equipment);
    }
}
