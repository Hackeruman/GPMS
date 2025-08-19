using UnityEngine;

public class ToolManager : MonoBehaviour
{
    public Tool currentTool;

    public void EquipTool(Tool newTool)
    {
        if (currentTool != null)
        {
            currentTool.gameObject.SetActive(false);
        }

        currentTool = newTool;

        if (currentTool != null)
        {
            currentTool.gameObject.SetActive(true);
        }
    }

    public ToolType GetCurrentToolType()
    {
        return currentTool != null ? currentTool.toolType : ToolType.None;
    }
}
