
//===================================================
//作    者：边涯  http://www.u3dol.com
//创建时间：2020-01-10 15:46:15
//备    注：此代码为工具生成 请勿手工修改
//===================================================
using System.Collections;
using YouYouFramework;

/// <summary>
/// Sys_SceneDetail实体
/// </summary>
public partial class Sys_SceneDetailEntity : DataTableEntityBase
{
    /// <summary>
    /// 场景编号
    /// </summary>
    public int SceneId;

    /// <summary>
    /// 场景路径
    /// </summary>
    public string ScenePath;

    /// <summary>
    /// 场景等级（0=必须，1=重要，2=不重要）
    /// </summary>
    public int SceneGrade;

}