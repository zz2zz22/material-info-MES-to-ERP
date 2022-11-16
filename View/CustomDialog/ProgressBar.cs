using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaterialMES2ERP
{
    public partial class ProgressBar : Form
    {
        public ProgressBar()
        {
            InitializeComponent();
        }
        public void UpdateProgress(int progress, string announce)
        {
            lbCustomAnnounce.BeginInvoke(
                new Action(() =>
                {
                    lbCustomAnnounce.Text = announce + progress + "%";
                }));
            xuipgbProgress.BeginInvoke(
                new Action(() =>
                {
                    xuipgbProgress.Value = progress;
                }
            ));
        }
    }
}
