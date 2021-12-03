using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayoutFloor : MonoBehaviour
{
    public Vector3 CellSize = Vector3.zero;
    public Vector3 CellCount = Vector3.zero;
    public List<Transform> floorTransforms = new List<Transform>();

    [ContextMenu("重置布局")]
    private void ResetFloorLayout()
    {
        floorTransforms.Clear();
        // 获取所有子物体
        for (int i = 0; i < transform.childCount; i++)
        {
            floorTransforms.Add(transform.GetChild(i));
        }

        // 布局子物体
        int curIndex = 0;
        for (int x = 0; x < CellCount.x; x++)
        {
            for (int z = 0; z < CellCount.z; z++)
            {
                floorTransforms[curIndex].position = new Vector3(CellSize.x * x, 0, CellSize.z * z);
                curIndex++;
            }
        }

    }
}
