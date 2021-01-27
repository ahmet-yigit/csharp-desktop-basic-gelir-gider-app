using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YTM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ytmDBEntities ytmEntities = new ytmDBEntities();
        private void txtGelirTutar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtGiderTutar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        void DataGridDoldur()
        {
            dataGridGelir.DataSource = ytmEntities.gelir.OrderByDescending(x => x.gelirId).ToList();
            dataGridGider.DataSource = ytmEntities.gider.OrderByDescending(x => x.giderId).ToList();
            int sumGelir = 0;
            int sumGider = 0;
            for (int i = 0; i < dataGridGelir.Rows.Count; i++)
            {
                sumGelir += Convert.ToInt32(dataGridGelir.Rows[i].Cells[2].Value);
            }
            lblGenelGelirToplam.Text = sumGelir.ToString() + " TL";
            for (int i = 0; i < dataGridGider.Rows.Count; i++)
            {
                sumGider += Convert.ToInt32(dataGridGider.Rows[i].Cells[2].Value);
            }
            lblGenelGiderToplam.Text = sumGider.ToString() + " TL";
            int genelDurum = sumGelir - sumGider;
            lblGenelDurum.Text = genelDurum + " TL";
        }

        DateTime dt = DateTime.Now;
        private void Form1_Load(object sender, EventArgs e)
        {
            DataGridDoldur();
        }

        private void gelirEkleBtn_Click(object sender, EventArgs e)
        {
            if (txtGelirTanim.Text != "" && txtGelirTutar.Text != "")
            {
                gelir gelirTable = new gelir();
                gelirTable.gelirTanim = txtGelirTanim.Text;
                gelirTable.gelirTutar = Convert.ToInt32(txtGelirTutar.Text);
                gelirTable.gelirDate = Convert.ToDateTime(dt.ToShortDateString());
                gelirTable.gelirSearch = (dt.ToString("MMMM") + dt.Year.ToString());
                ytmEntities.gelir.Add(gelirTable);
                ytmEntities.SaveChanges();
                MessageBox.Show("Gelir Veritabanına Başarılı Şekilde Eklendi!");
                txtGelirTanim.Text = "";
                txtGelirTutar.Text = "";
                dataGridGelir.DataSource = ytmEntities.gelir.OrderByDescending(x => x.gelirId).ToList();
            }
            else
            {
                MessageBox.Show("Boş alanları doldurunuz!");
            }
            DataGridDoldur();
        }

        private void giderEkleBtn_Click(object sender, EventArgs e)
        {
            if (txtGiderTanim.Text != "" && txtGiderTutar.Text != "")
            {
                gider giderTable = new gider();
                giderTable.giderTanim = txtGiderTanim.Text;
                giderTable.giderTutar = Convert.ToInt32(txtGiderTutar.Text);
                giderTable.giderDate = Convert.ToDateTime(dt.ToShortDateString());
                giderTable.giderSearch = (dt.ToString("MMMM") + dt.Year.ToString());
                ytmEntities.gider.Add(giderTable);
                ytmEntities.SaveChanges();
                MessageBox.Show("Gider Veritabanına Başarılı Şekilde Eklendi!");
                txtGiderTanim.Text = "";
                txtGiderTutar.Text = "";
                dataGridGider.DataSource = ytmEntities.gider.OrderByDescending(x => x.giderId).ToList();
            }
            else
            {
                MessageBox.Show("Boş alanları doldurunuz!");
            }
            DataGridDoldur();
        }

        private void giderSearchBtn_Click(object sender, EventArgs e)
        {
            DateTime startDate = baslangicPicker.Value;
            DateTime endDate = bitisPicker.Value;

            if (endDate < startDate || endDate == startDate)
            {
                MessageBox.Show("Bitiş Tarihi Başlangıç Tarihinden Küçük Olamaz");
            }
            else
            {
                var filteredDataGelir = from x in ytmEntities.gelir select x;
                var filteredDataGider = from x in ytmEntities.gider select x;
                dataGridGelir.DataSource = filteredDataGelir.Where(t => t.gelirDate >= startDate && t.gelirDate <= endDate).ToList();
                dataGridGider.DataSource = filteredDataGider.Where(t => t.giderDate >= startDate && t.giderDate <= endDate).ToList();
                int sumGelir = 0;
                int sumGider = 0;
                for (int i = 0; i < dataGridGelir.Rows.Count; ++i)
                {
                    sumGelir += Convert.ToInt32(dataGridGelir.Rows[i].Cells[2].Value);
                }
                lblSearchGelirToplam.Text = sumGelir.ToString();
                for (int i = 0; i < dataGridGider.Rows.Count; ++i)
                {
                    sumGider += Convert.ToInt32(dataGridGider.Rows[i].Cells[2].Value);
                }
                lblSearchGiderToplam.Text = sumGider.ToString();
                int searchToplam = sumGelir - sumGider;
                if (searchToplam < 0)
                {
                    lblSearchDurum.Text = searchToplam.ToString() + " TL Zarar";
                }
                else if (searchToplam==0)
                {
                    lblSearchDurum.Text = searchToplam.ToString() + " TL";
                }
                else
                {
                    lblSearchDurum.Text = searchToplam.ToString() + " TL Kar";
                }
            }
        }



        private void txtMonthSearch_TextChanged(object sender, EventArgs e)
        {
            var searchMonthGelir = from x in ytmEntities.gelir select x;
            var searchMonthGider = from x in ytmEntities.gider select x;

            if (txtMonthSearch.Text != null)
            {
                dataGridGelir.DataSource = searchMonthGelir.Where(x => x.gelirSearch.Contains(txtMonthSearch.Text)).ToList();
                dataGridGider.DataSource = searchMonthGider.Where(x => x.giderSearch.Contains(txtMonthSearch.Text)).ToList();
            }
            int sumGelir = 0;
            int sumGider = 0;
            for (int i = 0; i < dataGridGelir.Rows.Count; ++i)
            {
                sumGelir += Convert.ToInt32(dataGridGelir.Rows[i].Cells[2].Value);
            }
            lblSearchGelirToplam.Text = sumGelir.ToString() + " TL";
            for (int i = 0; i < dataGridGider.Rows.Count; ++i)
            {
                sumGider += Convert.ToInt32(dataGridGider.Rows[i].Cells[2].Value);
            }
            lblSearchGiderToplam.Text = sumGider.ToString() + " TL";
            int searchDurum = sumGelir - sumGider;
            if (searchDurum < 0)
            {
                lblSearchDurum.Text = searchDurum.ToString() + " TL Zarar";
            }
            else
            {
                lblSearchDurum.Text = searchDurum.ToString() + " TL Kar";
            }
        }

        private void txtGelirGiderSearch_TextChanged(object sender, EventArgs e)
        {
            var searchGelir = from x in ytmEntities.gelir select x;
            var searchGider = from x in ytmEntities.gider select x;

            if (txtGelirGiderSearch.Text != null)
            {
                dataGridGelir.DataSource = searchGelir.Where(x => x.gelirTanim.Contains(txtGelirGiderSearch.Text)).ToList();
                dataGridGider.DataSource = searchGider.Where(x => x.giderTanim.Contains(txtGelirGiderSearch.Text)).ToList();
            }
            int sumGelir = 0;
            int sumGider = 0;
            for (int i = 0; i < dataGridGelir.Rows.Count; ++i)
            {
                sumGelir += Convert.ToInt32(dataGridGelir.Rows[i].Cells[2].Value);
            }
            lblSearchGelirToplam.Text = sumGelir.ToString() + " TL";
            for (int i = 0; i < dataGridGider.Rows.Count; ++i)
            {
                sumGider += Convert.ToInt32(dataGridGider.Rows[i].Cells[2].Value);
            }
            lblSearchGiderToplam.Text = sumGider.ToString() + " TL";
            int searchDurum = sumGelir - sumGider;
            if (searchDurum < 0)
            {
                lblSearchDurum.Text = searchDurum.ToString() + " TL Zarar";
            }
            else
            {
                lblSearchDurum.Text = searchDurum.ToString() + " TL Kar";

            }


        }

        private void dataGridGelir_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtGelirId.Text = dataGridGelir.CurrentRow.Cells[0].Value.ToString();
            txtGelirDescription.Text = dataGridGelir.CurrentRow.Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int gelirId = int.Parse(dataGridGelir.CurrentRow.Cells[0].Value.ToString());
            var tbl = ytmEntities.gelir.FirstOrDefault(x => x.gelirId == gelirId);
            ytmEntities.gelir.Remove(tbl);
            ytmEntities.SaveChanges();
            MessageBox.Show("Kayıt Başarılı Şekilde Silindi");
            txtGelirId.Text = "";
            txtGelirDescription.Text = "";
            DataGridDoldur();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int gelirId = int.Parse(dataGridGider.CurrentRow.Cells[0].Value.ToString());
            var tbl = ytmEntities.gider.FirstOrDefault(x => x.giderId == gelirId);
            ytmEntities.gider.Remove(tbl);
            ytmEntities.SaveChanges();
            MessageBox.Show("Kayıt Başarılı Şekilde Silindi");
            txtGiderId.Text = "";
            txtGiderDescription.Text = "";
            DataGridDoldur();
        }

        private void dataGridGider_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtGiderId.Text = dataGridGider.CurrentRow.Cells[0].Value.ToString();
            txtGiderDescription.Text = dataGridGider.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
