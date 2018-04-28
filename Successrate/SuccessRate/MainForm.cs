using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SuccessRate
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            decimal SucRateLessOrEqual = 0;
            decimal SucRateGreater = 0;
            decimal FailRateLessOrEqual = 0;
            decimal FailRateGreater = 0;      
            for (decimal i = 1; i <= 100; i++)
            {
                if (i <= nudSkillVal.Value) 
                {
                    if (i % 10 == 0 || i % 10 > nudSkillVal.Value % 10) 
                    {
                        SucRateGreater++;
                    }
                    else
                    {
                        SucRateLessOrEqual++;
                    }
                }
                else
                {
                    if (i % 10 == 0 || i % 10 > nudSkillVal.Value % 10)
                    {
                        FailRateGreater++;
                    }
                    else
                    {
                        FailRateLessOrEqual++;
                    }
                }
            }
            decimal SucRate = SucRateLessOrEqual + SucRateGreater;
            if (rbtnBonus.Checked)
            {
                decimal Num = nudNum.Value;
                while (Num != 0)
                {
                    FailRateLessOrEqual = FailRateLessOrEqual * ((10 - Math.Floor(nudSkillVal.Value / 10) - 1) / 10);
                    FailRateGreater = FailRateGreater * ((10 - Math.Floor(nudSkillVal.Value / 10)) / 10);
                    Num--;
                }
                SucRate = 100 - FailRateLessOrEqual - FailRateGreater;
            }
            else if (rbtnPunish.Checked)
            {
                decimal Num = nudNum.Value;
                while (Num != 0)
                {
                    SucRateLessOrEqual = SucRateLessOrEqual * ((Math.Floor(nudSkillVal.Value / 10) + 1) / 10);
                    SucRateGreater = SucRateGreater * ((Math.Floor(nudSkillVal.Value / 10)) / 10);
                    Num--;
                }
                SucRate = SucRateLessOrEqual + SucRateGreater;
            }
            MessageBox.Show("成功率为: " + SucRate.ToString() + "%", "Success Rate Calculator", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RbtnDoNotAdd_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtnDoNotAdd.Checked)
            {
                nudNum.Enabled = false;
            }
            else
            {
                nudNum.Enabled = true;
            }
        }
    }
}
