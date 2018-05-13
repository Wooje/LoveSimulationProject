using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpriteOutputSystem : MonoBehaviour
{
    //stat text
    public TextAsset statfile;      //캐릭터 상태
    public Text Name;
    public string[] statLines;

    // 현재와 끝 라인을 표시하는 int 변수
    public int currentLine;
    public int endAtLine;

    public GameObject character;
    private SpriteRenderer spriteRenderer;
    public Sprite[] sprite;

    // Use this for initialization
    void Start()
    {
        if (statfile != null)
        {
            statLines = statfile.text.Split('\n');
        }
        // text 파일이 몇 줄인지 계산.
        if (endAtLine == 0)
            endAtLine = statLines.Length - 1;

        spriteRenderer = character.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Name.text.Contains("우제") == true)
        {
            //상태에 따라 캐릭터 스프라이트 불러오기
            if (statLines[currentLine].Contains("nomal") == true)
            {
                spriteRenderer.sprite = sprite[0];
                spriteRenderer.transform.position = character.transform.position;
                spriteRenderer.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
            }
            if (statLines[currentLine].Contains("smile") == true)
            {
                spriteRenderer.sprite = sprite[1];
                spriteRenderer.transform.position = character.transform.position;
                spriteRenderer.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
            }
            if (statLines[currentLine].Contains("very_smile") == true)
            {
                spriteRenderer.sprite = sprite[2];
                spriteRenderer.transform.position = character.transform.position;
                spriteRenderer.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
            }
        }


        if (Input.GetMouseButtonDown(0))
        {
            currentLine += 1;
        }
    }
}
