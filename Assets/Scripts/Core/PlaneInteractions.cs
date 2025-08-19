using UnityEngine;

public class InteractablePlanePart : MonoBehaviour
{
    public string partName = "Unknown Part";
    public ToolType requiredTool = ToolType.None;

    public void Interact(Tool tool)
    {
        if (tool != null && tool.toolType == requiredTool)
        {
            Debug.Log($"✅ Correct tool ({tool.toolName}) used on {partName}");
            // Do repair, animation, progress, etc.
        }
        else
        {
            string usedToolName = tool != null ? tool.toolName : "No Tool";
            Debug.Log($"❌ Wrong tool! {partName} needs {requiredTool}, but player has {usedToolName}");
        }
    }

    public string GetInteractionPrompt(Tool tool)
    {
        if (tool != null && tool.toolType == requiredTool)
            return $"[E] Use {tool.toolName} on {partName}";
        else
            return $"{partName} requires {requiredTool}";
    }
}
