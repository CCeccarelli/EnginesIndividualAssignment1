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
    private static extern int loadFileX();

    [DllImport(DLL_NAME)]
    private static extern int loadFileY();

    [DllImport(DLL_NAME)]
    private static extern int loadFileZ();
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
        int loadX = loadFileX();
        int loadY = loadFileY();
        int loadZ = loadFileZ();

        //string data = "10,10,10";


        //player.transform.position = new Vector3(loadX, loadY, loadZ);
        player.transform.position = new Vector3(loadX, loadY, loadZ);
    }
}
