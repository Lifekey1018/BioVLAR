using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ProtocolManager : MonoBehaviour
{

    private CSVReader csvReader;
    private TextMeshPro ProtocolText;
    // Start is called before the first frame update
    void Start()
    {
        csvReader = GameObject.Find("CSVReader").GetComponent<CSVReader>();
        csvReader.Read("ion");
        ProtocolText = GameObject.Find("ProtocolText").GetComponent<TextMeshPro>();
        ProtocolText.text = "";
        for (int i = 0; i < csvReader.csvData.Count; i++)
        {
            // UnityEngine.Debug.Log("“ú–{ŒêF" + csvReader.csvData[i][0] + ", ‰pŒêF" + csvReader.csvData[i][1]);
            ProtocolText.text += (i + 1) + ". " + csvReader.csvData[i][0] + "\n";
        }
        /* Protocol = gameObject.transform.Find("ProtocolCanvas").gameObject;
         if (Protocol == null)
         {
             throw new System.Exception("Protocol Empty");
         }*/
        // ProtocolText = Protocol.transform.Find("ProtocolText").gameObject.GetComponent<TextMesh>();
        csvReader.csvData.Clear();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
