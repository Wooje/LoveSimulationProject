using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpriteOutputSystem : MonoBehaviour
{
    //stat text
    public Text Name;

    public GameObject character;
    private SpriteRenderer spriteRenderer;
    public Sprite[] sprite;

    public TextImporter textimporter;

    // Use this for initialization
    void Start()
    {
        spriteRenderer = character.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
         if (Name.text.Contains("우제") == true)
        {
            //상태에 따라 캐릭터 스프라이트 불러오기
            if (textimporter.statline.Contains("보통") == true)
            {
                spriteRenderer.sprite = sprite[0];
                spriteRenderer.transform.position = character.transform.position;
                spriteRenderer.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
            }
            if (textimporter.statline.Contains("미소") == true)
            {
                spriteRenderer.sprite = sprite[1];
                spriteRenderer.transform.position = character.transform.position;
                spriteRenderer.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
            }
            if (textimporter.statline.Contains("썩소") == true)
            {
                spriteRenderer.sprite = sprite[2];
                spriteRenderer.transform.position = character.transform.position;
                spriteRenderer.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
            }
        }
    }
}
