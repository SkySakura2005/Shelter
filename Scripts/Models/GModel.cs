using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using QFramework;
namespace Shelter
{
    public class GModel : AbstractModel
    {
        public struct Levels
        {
            public string name;
            public bool hasFront;
            public int frontLevel;
            public int condition1;
            public int condition2;
            public string information;
        }
        public Dictionary<int, Levels> levelsDic=new Dictionary<int, Levels>();
        protected override void OnInit()
        {
            Levels samLevels = new Levels();
            #region G2000001
            samLevels.name = "��һ��";
            samLevels.hasFront = false;
            samLevels.information = "";
            levelsDic[2000001] = samLevels;
            #endregion
            #region G2000002
            samLevels.name = "�ڶ���";
            samLevels.hasFront = false;
            samLevels.frontLevel = 2000001;
            samLevels.information = "��һ�η籩����3�����";
            levelsDic[2000002] = samLevels;
            #endregion
            #region G2000003
            samLevels.name = "������";
            samLevels.hasFront = true;
            samLevels.frontLevel = 2000002;
            samLevels.condition1 = 1;
            samLevels.condition2 = 1;
            samLevels.information = "";
            levelsDic[2000003] = samLevels;
            #endregion
            #region G2000004
            samLevels.name = "���Ĺ�";
            samLevels.hasFront = true;
            samLevels.frontLevel = 2000003;
            samLevels.condition1 = 1;
            samLevels.condition2 = 1;
            samLevels.information = "";
            levelsDic[2000004] = samLevels;
            #endregion
            #region G2000005
            samLevels.name = "�����";
            samLevels.hasFront = true;
            samLevels.frontLevel = 2000004;
            samLevels.condition1 = 1;
            samLevels.condition2 = 1;
            samLevels.information = "";
            levelsDic[2000005] = samLevels;
            #endregion
            #region G2000006
            samLevels.name = "������";
            samLevels.hasFront = true;
            samLevels.frontLevel = 2000005;
            samLevels.condition1 = 1;
            samLevels.condition2 = 1;
            samLevels.information = "";
            levelsDic[2000006] = samLevels;
            #endregion
            #region G2000007
            samLevels.name = "���߹�";
            samLevels.hasFront = true;
            samLevels.frontLevel = 2000006;
            samLevels.condition1 = 1;
            samLevels.condition2 = 1;
            samLevels.information = "";
            levelsDic[2000007] = samLevels;
            #endregion
            #region G2000008
            samLevels.name = "�ڰ˹�";
            samLevels.hasFront = true;
            samLevels.frontLevel = 2000007;
            samLevels.condition1 = 1;
            samLevels.condition2 = 1;
            samLevels.information = "";
            levelsDic[2000008] = samLevels;
            #endregion
            #region G2000009
            samLevels.name = "�ھŹ�";
            samLevels.hasFront = true;
            samLevels.frontLevel = 2000008;
            samLevels.condition1 = 1;
            samLevels.condition2 = 1;
            samLevels.information = "";
            levelsDic[2000009] = samLevels;
            #endregion
            #region G2000010
            samLevels.name = "��ʮ��";
            samLevels.hasFront = true;
            samLevels.frontLevel = 2000009;
            samLevels.condition1 = 1;
            samLevels.condition2 = 1;
            samLevels.information = "";
            levelsDic[2000010] = samLevels;
            #endregion
        }
    }
}


