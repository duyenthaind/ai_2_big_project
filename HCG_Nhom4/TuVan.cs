using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace HCG_Nhom4
{
    public partial class TuVan : Form
    {
        private List<string> listMaNganh = new List<string>();
        private List<string> listTenNganh = new List<string>();
        private List<String> start = null;

        public TuVan()
        {
            InitializeComponent();
        }

        private void btnchon_Click(object sender, EventArgs e)
        {
            lstdulieu.Items.Add(dgvdulieu.CurrentRow.Cells[0].Value.ToString() + ": " +
                                dgvdulieu.CurrentRow.Cells[1].Value.ToString());
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            lstdulieu.Items.RemoveAt(lstdulieu.SelectedIndex);
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            lstdulieu.Items.Clear();
            lstketqua.Items.Clear();
        }

        private void TuVan_Load(object sender, EventArgs e)
        {
            btnchitiet.Enabled = false;
            Event_Controller sukien = new Event_Controller();
            DataTable tb = new DataTable();
            tb = sukien.loadDuLieu();
            dgvdulieu.DataSource = tb;
            DataTable tbTruong = sukien.getNganh();
            for (int i = 0; i < tbTruong.Rows.Count; i++)
            {
                listMaNganh.Add(tbTruong.Rows[i][0].ToString());
                listTenNganh.Add(tbTruong.Rows[i][1].ToString());
            }
        }

        private void btntuvan_Click(object sender, EventArgs e)
        {
            lstketqua.Items.Clear();
            var process = new Process();
            process.Load();
            progressBar.Maximum = listMaNganh.Count - 1;
            progressBar.Minimum = 0;
            if (lstdulieu.Items.Count == 0)
            {
                MessageBox.Show("Không có thông tin dữ kiện, không thể chuẩn đoán được ngành nghề phù hợp!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                start = new List<String>();

                var regex = new Regex(": ");

                for (int i = 0; i < lstdulieu.Items.Count; i++)
                {
                    String[] r;
                    r = regex.Split(lstdulieu.Items[i].ToString());
                    start.Add(r[0]);
                }

                for (int i = 0; i < listMaNganh.Count; i++)
                    progressBar.Value = i;
                List<int> listSubIndices = process.DoProcess(start, listMaNganh);
                if (listSubIndices.Count == 0)
                {
                    lstketqua.Items.Add("Các dữ kiện chưa đủ để đưa ra ngành nghề phù hợp với bạn!");
                    lstketqua.Items.Add("\t" + "==> Không thể tư vấn được ngành nghề phù hợp!");
                }
                else
                {
                    for (int i = 0; i < listSubIndices.Count; i++)
                    {
                        int value = listSubIndices[i];
                        lstketqua.Items.Add(listTenNganh[value]);
                    }
                }
            }
        }

        private void btnchitiet_Click(object sender, EventArgs e)
        {
            String a = lstketqua.SelectedItem.ToString();
            switch (a)
            {
                case "Luật sư":
                    MessageBox.Show(
                        "học ngành luật, bạn sẽ được đào tạo kiến thức về pháp luật.Tùy thuộc vào mỗi chuyên ngành mà bạn sẽ được trang bị kiến thức khác nhau.",
                        a);
                    break;
                case "Nghệ thuật":
                    MessageBox.Show(
                        "Nghệ thuật có rất nhiều ngành liên quan như: biên kịch,đạo diễn,diễn viên, quảng cáo, âm nhạc, truyền thông,...",
                        a);
                    break;
                case "Sư phạm":
                    MessageBox.Show(
                        "Ngành sư phạm là khoa học về giáo dục và giảng dạy trong trường học. Còn theo cách hiểu giản dị nhất,  sư phạm có nghĩa là người thầy mẫu mực, khuôn phép, tấm gương sáng cho học trò noi theo.Làm việc trong ngành sư phạm là tham gia vào sự nghiệp trồng người, đào tạo nguồn nhân lực cho các ngành nghề, lĩnh vực của xã hội.",
                        a);
                    break;
                case "Thể thao":
                    MessageBox.Show("Thể thao có rất nhiều ngành liên quan như: sư phạm thể dục,vận động viên,...", a);
                    break;
                case "Kiến trúc,xây dựng":
                    MessageBox.Show(
                        "Kiến trúc là một ngành nghệ thuật và khoa học về tổ chức sắp xếp không gian, lập hồ sơ thiết kế các công trình kiến trúc.Người học kiến trúc là người có đam mê về đồ họa, sáng tạo ",
                        a);
                    break;
                case "Báo chí":
                    MessageBox.Show(
                        "Ngành báo chí  là ngành học chuyên đào tạo những sinh viên có đủ kỹ năng, kiến thức, năng lực thực hiện quyền và trách nhiệm của người làm báo trong xã hội.Giúp sinh viên nhận thức trách nhiệm xã hội,luật pháp, đạo đức của nhà báo để phục vụ trong các cơ quan Báo chí, Tạp chí của Nhà nước.",
                        a);
                    break;
                case "Công nghệ thông tin":
                    MessageBox.Show(
                        "Công nghệ thông tin là một ngành học được đào tạo để sử dụng máy tính và các phần mềm máy tính để phân phối và xử lý các dữ liệu thông tin, đồng thời dùng để trao đổi, lưu trữ và chuyển đổi các dữ liệu thông tin dưới nhiều hình thức khác nhau.",
                        a);
                    break;
                case "Quản trị kinh doanh, marketing":
                    MessageBox.Show(
                        "Quản trị kinh doanh là một ngành tổng hợp gồm nhiều bộ môn căn bản về “quản trị” và “kinh doanh”.Nói cách khác, khi đăng ký ngành này, bạn sẽ được đào tạo đầy đủ những kiến thức căn bản trong khối ngành  kinh tế như tài chính, kế toán, nhân sự cho tới các chiến lược kinh doanh, marketing.",
                        a);
                    break;
                case "Ngân hàng":
                    MessageBox.Show(
                        "Đây là ngành học khá rộng, liên quan đến tất cả các dịch vụ giao dịch tài chính, lưu thông và vận hành tiền tệ.Cụ thể hơn, ngành tài chính ngân hàng là kinh doanh về lĩnh vực tiền tệ thông qua ngân hàng và các công cụ tài chính được ngân hàng phát hành nhằm bảo lãnh, thanh toán, chi trả trong nội địa và quốc tế.",
                        a);
                    break;
                case "Kế toán":
                    MessageBox.Show(
                        "kế toán là ngành thực hiện quá trình thu nhận, xử lý và cung cấp thông tin về toàn bộ tài sản, nguồn hình thành tài sản và sự vận động tài sản trong doanh nghiệp, tổ chức, từ đó cung cấp thông tin  tài chính hữu ích cho việc đưa ra những quyết định về kinh tế - xã hội",
                        a);
                    break;
                case "Thiên văn học":
                    MessageBox.Show(
                        "Thiên văn học là việc nghiên cứu khoa học các thiên thể (như các ngôi sao, hành tinh, sao chổi, tinh vân, quần tinh, thiên hà) và các hiện tượng có nguồn gốc bên ngoài vũ trụ(như bức xạ nền vũ trụ).",
                        a);
                    break;
                case "Vật lý học":
                    MessageBox.Show(
                        "Vật lý học - một cách tổng quát nhất đó là khoa học nghiên cứu về vật chất và sự tương tác Cụ thể thì Vật lý là khoa học nghiên cứu về các quy luật vận động của tự nhiên, từ thang vi mô (các hạt cấu tạo nên vật chất) cho đến thang vĩ mô(các hành tinh, thiên hà và vũ trụ).",
                        a);
                    break;
                case "Hóa học":
                    MessageBox.Show(
                        "Hóa học  chính là một nhánh của ngành Khoa học tự nhiên, nói cách khác thì ngành Hóa học chính là ngành nghiên cứu thành phần, tính chất, cấu trúc và sự thay đổi của tất cả các loại vật chất  trong tự nhiên và con người.",
                        a);
                    break;
                case "Cơ khí":
                    MessageBox.Show(
                        "Kỹ thuật cơ khí là một ngành Khoa học kỹ thuật, ứng dụng các nguyên lý vật lý, kỹ thuật và khoa học vật liệu để thiết kế, phân tích, chế tạo và bảo dưỡng các loại máy móc và hệ thống cơ khí. ... Kỹ thuật Cơ khí là ngành lâu đời nhất, rộng lớn nhất của Kỹ thuật.",
                        a);
                    break;
                case "Ô tô":
                    MessageBox.Show(
                        "Kỹ thuật Ô tô là ngành tích hợp kiến thức của nhiều lĩnh vực: Cơ khí, tự động hoá, điện – điện tử, công nghệ chế tạo máy móc, quản lý dịch vụ kỹ thuật ô tô như điều hành sản xuất phụ tùng, lắp ráp, cải tiến và nâng cao hiệu quả sử dụng.",
                        a);
                    break;
                case "Kỹ thuật điện, điện tử":
                    MessageBox.Show(
                        "Kỹ thuật điện, điện tử là ngành học nghiên cứu và áp dụng các vấn đề liên quan đến điện, điện tử và điện từ với nhiều chuyên ngành nhỏ như năng lượng, điện tử học, hệ thống điều khiển, xử lý tín hiệu, viễn thông.",
                        a);
                    break;
                case "Hướng dẫn viên du lịch":
                    MessageBox.Show(
                        "Hướng dẫn viên du lịch là ngành học năng động, bao gồm quá trình quản lý và điều hành du lịch, chịu trách nhiệm phân công công việc cho các hướng dẫn viên du lịch; nhận thông tin để phối hợp với các bộ phận, cơ quan chức năng giải quyết những phát sinh, thiết kế các chương trình du lịch,",
                        a);
                    break;
                case "Sinh học":
                    MessageBox.Show(
                        "Sinh học là ngành khoa học nghiên cứu về sự sống. ... Đây là ngành học nghiên cứu về nguồn gốc, sự phát triển và đời sống của sinh vật ",
                        a);
                    break;
                case "Y, dược học":
                    MessageBox.Show(
                        "Ngành y là ngành chuyên tổ chức việc phòng bệnh, chữa bệnh và bảo vệ sức khoẻ cho con người và các loại động vật. Dược học hay dược là lĩnh vực khoa học ứng dụng, nghiên cứu về thuốc trên 2 lĩnh vực chính gồm quá trình nghiên cứu mối liên quan giữa thuốc và cơ thể",
                        a);
                    break;
                case "Hàng không":
                    MessageBox.Show(
                        "Hàng không có rất nhiều ngành liên quan như: Phi công, huấn luyện bay, nhân viên kiểm soát, tiếp viên hàng không,...",
                        a);
                    break;
                case "Công an":
                    MessageBox.Show(
                        "Công an đảm bảo an ninh và sự bình yên về mọi mặt cho Tổ quốc, ngành công an được chia thành hai lực lượng chính: Cảnh sát: bảo vệ và giữ gìn trật tư, an toàn xã hội và An ninh: bảo vệ an ninh quốc gia, bảo vệ chế độ xã hội chủ nghĩa, bảo vệ Đảng, chính quyền, các lực lượng vũ trang và nhân dân.",
                        a);
                    break;
                case "Quân đội":
                    MessageBox.Show(
                        "Quân đội là lực lượng đảm bảo quốc phòng an ninh quốc gia, họ luôn sẵn sàng chiến đấu, đánh bại kẻ thù xâm lược để bảo vệ Tổ quốc.Quân đội là lực lượng có tổ chức, được trang bị vũ khí, phương tiện kỹ thuật quân sự và huấn luyện quân sự chuyên nghiệp.",
                        a);
                    break;
                case "Phiên dịch":
                    MessageBox.Show(
                        "phiên dịch viên là người chuyên làm công việc chuyển các văn bản (nói hoặc viết) từ ngôn ngữ này sang ngôn ngữ khác một cách chính xác, giúp những người không cùng sử dụng một ngôn ngữ có thể hiểu nhau.",
                        a);
                    break;
                case "Đầu bếp":
                    MessageBox.Show(
                        "Đầu bếp là một ngành nghề đặc thù yêu cầu sự tỉ mỉ, kiên nhẫn, khéo léo và sáng tạo. Nó chính là nghề chế biến các món ăn",
                        a);
                    break;
            }
        }

        private void lstketqua_MouseClick(object sender, MouseEventArgs e)
        {
            btnchitiet.Enabled = true;
        }
    }
}