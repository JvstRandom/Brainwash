using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class items : MonoBehaviour
{
    [SerializeField]
    public string i_Name;

    [SerializeField]
    public int i_quantity;

    [SerializeField]
    public Sprite i_sprite;

    [TextArea]
    [SerializeField]
    public string i_Desc;

    private InventoryManager invenManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
