using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace HCG_Nhom4
{
    public class Process
    {
        private RuleDAO ruleDao = new RuleDAO();
        List<Rule> bin = new List<Rule>();
        List<Rule> SAT = new List<Rule>();
        public void Load()
        {
            var ruleData = ruleDao.GetAllContent();
            for (int i = 0; i < ruleData.Rows.Count; i++)
            {
                string buff = ruleData.Rows[i][0].ToString();
                Rule luatTG = new Rule();
                char[] delimiterChars = { '>' };
                string[] tg = buff.Split(delimiterChars);

                //ben trai
                char[] delimiterChars1 = { '^' };
                string[] left = tg[0].Split(delimiterChars1);
                int j = 0;
                string buff1 = left[0];
                while (buff1 != null)
                {
                    luatTG.left.Add(buff1);
                    j++;
                    try
                    {
                        buff1 = left[j];
                    }
                    catch { buff1 = null; };

                }

                j = 0;

                //ben phai
                char[] delimiterChars2 = { ',' };
                string[] right = tg[1].Split(delimiterChars2);

                buff1 = right[0];
                while (buff1 != null)
                {
                    luatTG.right.Add(buff1);
                    j++;
                    try
                    {
                        buff1 = right[j];
                    }
                    catch { buff1 = null; };
                }

                bin.Add(luatTG);
            }

        }

        public string OutputResults(List<Rule> listRules)
        {
            var temp = "";
            foreach (var r in listRules)
            {
                foreach (var s in r.left)
                {
                    temp += s + "^";
                }
                temp += "->";
                foreach (var s in r.right)
                {
                    temp += s + "^";
                }
                temp += "\n";

            }
            return temp;
        } 

        /// <summary>
        /// hàm lấy ra 1 luật trong tập SAT để thực hiện việc suy diễn, lấy luật từ trái qua phải
        /// </summary>
        /// <param name="SAT">danh sách kết luận trong tập SAT</param>
        /// <returns></returns>

        public void FindSAT(List<string> temp, List<Rule> listRules)
        {
            bool isChecked;
            for (int i = 0; i < listRules.Count; i++)
            {

                isChecked = true;
                for (int j = 0; j < listRules[i].left.Count; j++)
                    if (temp.Contains(listRules[i].left[j]))
                        isChecked = isChecked && true;
                    else
                        isChecked = isChecked && false;
                if (isChecked)
                {
                    SAT.Add(listRules[i]);
                }
            }
        }

        public List<int> DoProcess(List<string> start, List<string> expected)
        {
            var temp = new List<string>();
            var listRules = new List<Rule>();
            var result = new List<string>();
            var indices = new List<int>();
            listRules = bin;
            temp = start;
            result = expected;
            FindSAT(temp, listRules);

            while (SAT.Count > 0)
            {

                //lay luat SAT đầu tiên ra ap dung
                Rule r = SAT[0];

                //them cai chua co vao TG
                foreach (string tg in r.right)
                {
                    if (!temp.Contains(tg))
                    {
                        temp.Add(tg);
                        Console.WriteLine(tg);
                    }

                }
                SAT.Remove(r);
                listRules.Remove(r);
                FindSAT(temp, listRules);
            }
            for (int i = 0; i < result.Count; i++)
            {
                if (start.Contains(result[i]))
                {
                    indices.Add(i);
                }


            }
            return indices;
        }
    }
}

