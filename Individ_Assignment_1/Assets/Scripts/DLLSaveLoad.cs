using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;
using UnityEngine.UI;

public class DLLSaveLoad : MonoBehaviour
{

    public Button saveB;
    public Button loadB;
    public GameObject player;

    const string DLL_NAME = "IndividDLLA";

    [DllImport(DLL_NAME)]
    private static extern void saveFile(float x, float y, float z);

    [DllImport(DLL_NAME)]
    private static extern string loadFile();
    // Start is called before the first frame update
    void Start()
    {
        Button bt = saveB.GetComponent<Button>();
        bt.onClick.AddListener(SaveOnClick);

        Button bl = loadB.GetComponent<Button>();
        bl.onClick.AddListener(LoadOnClick);
    }

    // Update is called once per frame
    
    void SaveOnClick()
    {
            saveFile(player.transform.position.x, player.transform.position.y, player.transform.position.z);
    }

    void LoadOnClick()
    {
        string data = loadFile();
        //string data = "10,10,10";
        string[] temp = data.Split(',');

        player.transform.position = new Vector3(float.Parse(temp[0]), float.Parse(temp[1]), float.Parse(temp[2]));
        //player.transform.position = new Vector3(5, 5, 5);
    }
}
