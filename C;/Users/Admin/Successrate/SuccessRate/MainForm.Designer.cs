namespace SuccessRate
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.nudSkillVal = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudNum = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtnPunish = new System.Windows.Forms.RadioButton();
            this.rbtnBonus = new System.Windows.Forms.RadioButton();
            this.rbtnDoNotAdd = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudSkillVal)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNum)).BeginInit();
            this.SuspendLayout();
            // 
            // nudSkillVal
            // 
            this.nudSkillVal.Font = new System.Drawing.Font("宋体", 15F);
            this.nudSkillVal.Location = new System.Drawing.Point(209, 87);
            this.nudSkillVal.Name = "nudSkillVal";
            this.nudSkillVal.Size = new System.Drawing.Size(55, 30);
            this.nudSkillVal.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F);
            this.label1.Location = new System.Drawing.Point(55, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "属性或技能值:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudNum);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rbtnPunish);
            this.groupBox1.Controls.Add(this.rbtnBonus);
            this.groupBox1.Controls.Add(this.rbtnDoNotAdd);
            this.groupBox1.Location = new System.Drawing.Point(324, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 170);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "惩罚骰或奖励骰";
            // 
            // nudNum
            // 
            this.nudNum.Enabled = false;
            this.nudNum.Font = new System.Drawing.Font("宋体", 9F);
            this.nudNum.Location = new System.Drawing.Point(247, 71);
            this.nudNum.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNum.Name = "nudNum";
            this.nudNum.Size = new System.Drawing.Size(55, 21);
            this.nudNum.TabIndex = 7;
            this.nudNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "个数:";
            // 
            // rbtnPunish
            // 
            this.rbtnPunish.AutoSize = true;
            this.rbtnPunish.Location = new System.Drawing.Point(37, 105);
            this.rbtnPunish.Name = "rbtnPunish";
            this.rbtnPunish.Size = new System.Drawing.Size(83, 16);
            this.rbtnPunish.TabIndex = 5;
            this.rbtnPunish.Text = "添加惩罚骰";
            this.rbtnPunish.UseVisualStyleBackColor = true;
            // 
            // rbtnBonus
            // 
            this.rbtnBonus.AutoSize = true;
            this.rbtnBonus.Location = new System.Drawing.Point(37, 72);
            this.rbtnBonus.Name = "rbtnBonus";
            this.rbtnBonus.Size = new System.Drawing.Size(83, 16);
            this.rbtnBonus.TabIndex = 4;
            this.rbtnBonus.Text = "添加奖励骰";
            this.rbtnBonus.UseVisualStyleBackColor = true;
            // 
            // rbtnDoNotAdd
            // 
            this.rbtnDoNotAdd.AutoSize = true;
            this.rbtnDoNotAdd.Checked = true;
            this.rbtnDoNotAdd.Location = new System.Drawing.Point(37, 40);
            this.rbtnDoNotAdd.Name = "rbtnDoNotAdd";
            this.rbtnDoNotAdd.Size = new System.Drawing.Size(59, 16);
            this.rbtnDoNotAdd.TabIndex = 3;
            this.rbtnDoNotAdd.TabStop = true;
            this.rbtnDoNotAdd.Text = "不填加";
            this.rbtnDoNotAdd.UseVisualStyleBackColor = true;
            this.rbtnDoNotAdd.CheckedChanged += new System.EventHandler(this.RbtnDoNotAdd_CheckedChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("宋体", 15F);
            this.btnCalculate.Location = new System.Drawing.Point(312, 243);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(122, 38);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "计算";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 336);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudSkillVal);
            this.Name = "MainForm";
            this.Text = "Success Rate Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.nudSkillVal)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudSkillVal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtnPunish;
        private System.Windows.Forms.RadioButton rbtnBonus;
        private System.Windows.Forms.RadioButton rbtnDoNotAdd;
        private System.Windows.Forms.Button btnCalculate;
    }
}

