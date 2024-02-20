using UnityEngine;

public class ProjectManager : MonoBehaviour
{
    /// <summary>
    /// 1.AllList
    /// 2.AllSing
    /// 3.BazaList
    /// 4.CoiList
    /// 5.DifferentList 
    /// </summary>

    public string lastMenu;

    public GameObject[] arrMenu;

    public void SetLastMenu(string id)
    {
        lastMenu = id;
    }

    public void GetLastMenu()
    {
        switch (lastMenu) 
        {
            case "AllList":
                arrMenu[0].gameObject.SetActive(true);
                //Debug.Log("0");
                break;
            case "AllSing":
                arrMenu[1].gameObject.SetActive(true);
                //Debug.Log("1");
                break;
            case "BazaList":
                arrMenu[2].gameObject.SetActive(true);
                //Debug.Log("2");
                break;
            case "CoiList":
                arrMenu[3].gameObject.SetActive(true);
                //Debug.Log("3");
                break;
            case "DifferentList":
                arrMenu[4].gameObject.SetActive(true);
                //Debug.Log("3");
                break;
            default:
                //Debug.Log("4?");
                break;
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
