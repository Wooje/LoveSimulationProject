using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextImporter : MonoBehaviour {

    //Text 공간 변수
    public TextAsset textfile;      //캐릭터 대사

    //Text 파일
    public Text Text;
    public Text Name;

    //Text 줄 내용
    [TextArea]  // text 개행 적용.
    public string[] textLines;
    public string statline;

    // 현재 라인을 표시하는 int 변수
    public int currentLine;



    void Start ()
    {       
        //text 라인을 나누는 기준.
        if (textfile != null)
        {
            textLines = textfile.text.Split('\n');
        }

        // text 창 초기화
        Text.text = "";
        StartCoroutine("Printing");             //코루틴 시작
    }




    void Update ()
    {
        // 터치시 코루틴 정지, 다음 라인으로 이동, 코루틴 다시 시작
        if (Input.GetMouseButtonDown(0))
        {
            StopCoroutine("Printing");
            Text.text = "";
            currentLine += 1;
            StartCoroutine("Printing");
        }
    }


    IEnumerator Printing()
    {
        // ':' 문자의 인덱스를 복사 후, ':' 를 기준으로 이름과 대사를 나누고 대사는 한 글자씩 출력
        int index = textLines[currentLine].IndexOf("#");
        int index2 = textLines[currentLine].IndexOf(":");

        Name.text = textLines[currentLine].Substring(0, index);
        statline = textLines[currentLine].Substring(index + 1, 2);

        for (int i = index2 + 1; i < textLines[currentLine].Length; i++)
        {
            Text.text += textLines[currentLine][i];
            yield return new WaitForSeconds(0.1f);
        }
        StopCoroutine("Printing");          // text 가 모두 출력되면 코루틴 정지
    }
}
