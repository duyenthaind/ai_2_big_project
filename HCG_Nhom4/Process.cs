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
            for (var i = 0; i < ruleData.Rows.Count; i++)
            {
                var buff = ruleData.Rows[i][0].ToString();
                var ruleTemp = new Rule();
                char[] delimiterChars = { '>' };
                var arrTemp = buff.Split(delimiterChars);

                //on the left
                char[] delimiterChars1 = { '^' };
                var left = arrTemp[0].Split(delimiterChars1);
                var j = 0;
                var buff1 = left[0];
                while (buff1 != null)
                {
                    ruleTemp.left.Add(buff1);
                    j++;
                    try
                    {
                        buff1 = left[j];
                    }
                    catch { buff1 = null; };

                }

                j = 0;

                //on the right
                char[] delimiterChars2 = { ',' };
                var right = arrTemp[1].Split(delimiterChars2);

                buff1 = right[0];
                while (buff1 != null)
                {
                    ruleTemp.right.Add(buff1);
                    j++;
                    try
                    {
                        buff1 = right[j];
                    }
                    catch { buff1 = null; };
                }

                bin.Add(ruleTemp);
            }

        }

        public string OutputResults(List<Rule> listRules)
        {
            var temp = "";
            foreach (var r in listRules)
            {
                temp = r.left.Aggregate(temp, (current, s) => current + (s + "^"));
                temp += "->";
                temp = r.right.Aggregate(temp, (current, s) => current + (s + "^"));
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
            foreach (var t in listRules)
            {
                isChecked = true;
                foreach (var t1 in t.left)
                    if (temp.Contains(t1))
                        isChecked = isChecked && true;
                    else
                        isChecked = isChecked && false;

                if (isChecked)
                {
                    SAT.Add(t);
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
                var r = SAT[0];

                //them cai chua co vao TG
                foreach (var tg in r.right.Where(tg => !temp.Contains(tg)))
                {
                    temp.Add(tg);
                    Console.WriteLine(tg);
                }
                SAT.Remove(r);
                listRules.Remove(r);
                FindSAT(temp, listRules);
            }
            for (var i = 0; i < result.Count; i++)
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

