using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Versioning;
using System.Text;
using System.Diagnostics;

public class CSVReader : MonoBehaviour
{
    private TextAsset csvFile;
    public List<string[]> csvData = new List<string[]>(); // protocol‚Ì’†g‚ğ“ü‚ê‚éƒŠƒXƒg

    public void Read(string filePath)
    {
        csvFile = Resources.Load(filePath) as TextAsset;
        StringReader reader = new StringReader(csvFile.text);
        UnityEngine.Debug.Log(reader.ReadLine());

        while (reader.Peek() != -1)
        {
            string line = reader.ReadLine();
            csvData.Add(line.Split(','));
        }
    }
}

