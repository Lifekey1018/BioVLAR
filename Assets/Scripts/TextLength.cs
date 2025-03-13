using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextLength : MonoBehaviour
{
    private CSVReader csvReader;
    // public TextMeshPro ProtocolText;
    public RectTransform bgRt;
    private float bgHeight;
    private float bgWidth;
    private int maxLength;
    private int numLines;
    private readonly float WIDTH_OFSET = 0.05f;
    private readonly float HEIGHT_OFSET = 0.35f;
    // Start is called before the first frame update
    void Start()
    {
        csvReader = GameObject.Find("CSVReader").GetComponent<CSVReader>();
        csvReader.Read("ion");
        maxLength = 0;
        numLines = csvReader.csvData.Count;
        for (int i = 0; i < csvReader.csvData.Count; i++)
        {
            if (maxLength < csvReader.csvData[i][0].Length)
            {
                maxLength = csvReader.csvData[i][0].Length;
            }
        }

       //  ProtocolText = GameObject.Find("ProtocolText").GetComponent<TextMeshPro>();
        UnityEngine.Debug.Log("before:"+this.bgRt.sizeDelta);
        //UnityEngine.Debug.Log(ProtocolText.text.Length);
        this.bgWidth = maxLength * WIDTH_OFSET;
        this.bgHeight = numLines * HEIGHT_OFSET;
        this.bgRt.localScale = new Vector3(this.bgWidth, this.bgHeight, this.bgRt.localScale.z);
        // UnityEngine.Debug.Log("after:"+this.bgRt.sizeDelta);
        csvReader.csvData.Clear();
    }

    // Update is called once per frame
    void Update()
    {
        /* ProtocolText = GameObject.Find("ProtocolText").GetComponent<TextMesh>();
         UnityEngine.Debug.Log(this.bgRt.sizeDelta);
         UnityEngine.Debug.Log(ProtocolText.text.Length);
         this.bgSize = this.bgRt.sizeDelta.x;
         this.bgRt.sizeDelta = new Vector2(this.bgSize + (ProtocolText.text.Length * this.TEXT_OFSET), this.bgRt.sizeDelta.y);
         UnityEngine.Debug.Log(this.bgRt.sizeDelta);*/
    }
}
