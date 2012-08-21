namespace ArmorSim
{
	partial class MainForm
	{
		/// <summary>
		/// 必要なデザイナ変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナで生成されたコード

		/// <summary>
		/// デザイナ サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディタで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.btnOption = new System.Windows.Forms.Button();
			this.cbハベルの指輪 = new System.Windows.Forms.CheckBox();
			this.cb割合 = new System.Windows.Forms.ComboBox();
			this.cb持久力 = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cb不可 = new System.Windows.Forms.CheckBox();
			this.cb光 = new System.Windows.Forms.CheckBox();
			this.cb通常 = new System.Windows.Forms.CheckBox();
			this.tb装備重量 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.cb原盤 = new System.Windows.Forms.CheckBox();
			this.tb結果 = new System.Windows.Forms.TextBox();
			this.brnCalc = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.lbList = new System.Windows.Forms.ListBox();
			this.cb順位数 = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.tb装備以外重量 = new System.Windows.Forms.TextBox();
			this.rb兜全て = new System.Windows.Forms.RadioButton();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.cb寵愛 = new System.Windows.Forms.CheckBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.cb兜 = new System.Windows.Forms.ComboBox();
			this.rb兜固定 = new System.Windows.Forms.RadioButton();
			this.rb兜なし = new System.Windows.Forms.RadioButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.cb鎧 = new System.Windows.Forms.ComboBox();
			this.rb鎧固定 = new System.Windows.Forms.RadioButton();
			this.rb鎧なし = new System.Windows.Forms.RadioButton();
			this.rb鎧全て = new System.Windows.Forms.RadioButton();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.cb手甲 = new System.Windows.Forms.ComboBox();
			this.rb手甲固定 = new System.Windows.Forms.RadioButton();
			this.rb手甲なし = new System.Windows.Forms.RadioButton();
			this.rb手甲全て = new System.Windows.Forms.RadioButton();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.cb足甲 = new System.Windows.Forms.ComboBox();
			this.rb足甲固定 = new System.Windows.Forms.RadioButton();
			this.rb足甲なし = new System.Windows.Forms.RadioButton();
			this.rb足甲全て = new System.Windows.Forms.RadioButton();
			this.groupBox1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(178, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "持久力";
			// 
			// btnOption
			// 
			this.btnOption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOption.Location = new System.Drawing.Point(717, 67);
			this.btnOption.Name = "btnOption";
			this.btnOption.Size = new System.Drawing.Size(75, 23);
			this.btnOption.TabIndex = 1;
			this.btnOption.Text = "オプション...";
			this.btnOption.UseVisualStyleBackColor = true;
			this.btnOption.Click += new System.EventHandler(this.btnOption_Click);
			// 
			// cbハベルの指輪
			// 
			this.cbハベルの指輪.AutoSize = true;
			this.cbハベルの指輪.Location = new System.Drawing.Point(126, 18);
			this.cbハベルの指輪.Name = "cbハベルの指輪";
			this.cbハベルの指輪.Size = new System.Drawing.Size(88, 16);
			this.cbハベルの指輪.TabIndex = 1;
			this.cbハベルの指輪.Text = "ハベルの指輪";
			this.cbハベルの指輪.UseVisualStyleBackColor = true;
			// 
			// cb割合
			// 
			this.cb割合.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb割合.FormattingEnabled = true;
			this.cb割合.Items.AddRange(new object[] {
            "1/1",
            "1/2",
            "1/4"});
			this.cb割合.Location = new System.Drawing.Point(180, 40);
			this.cb割合.Name = "cb割合";
			this.cb割合.Size = new System.Drawing.Size(60, 20);
			this.cb割合.TabIndex = 7;
			// 
			// cb持久力
			// 
			this.cb持久力.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb持久力.FormattingEnabled = true;
			this.cb持久力.Location = new System.Drawing.Point(224, 12);
			this.cb持久力.Name = "cb持久力";
			this.cb持久力.Size = new System.Drawing.Size(60, 20);
			this.cb持久力.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(246, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 12);
			this.label2.TabIndex = 0;
			this.label2.Text = "に抑える";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cb不可);
			this.groupBox1.Controls.Add(this.cb光);
			this.groupBox1.Controls.Add(this.cb通常);
			this.groupBox1.Location = new System.Drawing.Point(248, 70);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(156, 46);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "強化別対象";
			// 
			// cb不可
			// 
			this.cb不可.AutoSize = true;
			this.cb不可.Location = new System.Drawing.Point(102, 18);
			this.cb不可.Name = "cb不可";
			this.cb不可.Size = new System.Drawing.Size(48, 16);
			this.cb不可.TabIndex = 2;
			this.cb不可.Text = "不可";
			this.cb不可.UseVisualStyleBackColor = true;
			// 
			// cb光
			// 
			this.cb光.AutoSize = true;
			this.cb光.Location = new System.Drawing.Point(60, 18);
			this.cb光.Name = "cb光";
			this.cb光.Size = new System.Drawing.Size(36, 16);
			this.cb光.TabIndex = 1;
			this.cb光.Text = "光";
			this.cb光.UseVisualStyleBackColor = true;
			// 
			// cb通常
			// 
			this.cb通常.AutoSize = true;
			this.cb通常.Location = new System.Drawing.Point(6, 18);
			this.cb通常.Name = "cb通常";
			this.cb通常.Size = new System.Drawing.Size(48, 16);
			this.cb通常.TabIndex = 0;
			this.cb通常.Text = "通常";
			this.cb通常.UseVisualStyleBackColor = true;
			// 
			// tb装備重量
			// 
			this.tb装備重量.Location = new System.Drawing.Point(95, 40);
			this.tb装備重量.Name = "tb装備重量";
			this.tb装備重量.Size = new System.Drawing.Size(48, 19);
			this.tb装備重量.TabIndex = 6;
			this.tb装備重量.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(25, 43);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(62, 12);
			this.label3.TabIndex = 0;
			this.label3.Text = "装備重量を";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(152, 43);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(15, 12);
			this.label4.TabIndex = 0;
			this.label4.Text = "の";
			// 
			// cb原盤
			// 
			this.cb原盤.AutoSize = true;
			this.cb原盤.Location = new System.Drawing.Point(300, 14);
			this.cb原盤.Name = "cb原盤";
			this.cb原盤.Size = new System.Drawing.Size(100, 16);
			this.cb原盤.TabIndex = 5;
			this.cb原盤.Text = "楔石の原盤あり";
			this.cb原盤.UseVisualStyleBackColor = true;
			// 
			// tb結果
			// 
			this.tb結果.Font = new System.Drawing.Font("ＭＳ ゴシック", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.tb結果.Location = new System.Drawing.Point(410, 175);
			this.tb結果.Multiline = true;
			this.tb結果.Name = "tb結果";
			this.tb結果.ReadOnly = true;
			this.tb結果.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.tb結果.Size = new System.Drawing.Size(293, 149);
			this.tb結果.TabIndex = 15;
			// 
			// brnCalc
			// 
			this.brnCalc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.brnCalc.Location = new System.Drawing.Point(717, 38);
			this.brnCalc.Name = "brnCalc";
			this.brnCalc.Size = new System.Drawing.Size(75, 23);
			this.brnCalc.TabIndex = 0;
			this.brnCalc.Text = "計算";
			this.brnCalc.UseVisualStyleBackColor = true;
			this.brnCalc.Click += new System.EventHandler(this.brnCalc_Click);
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.Location = new System.Drawing.Point(717, 96);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 2;
			this.btnClose.Text = "閉じる";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// lbList
			// 
			this.lbList.Font = new System.Drawing.Font("ＭＳ ゴシック", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.lbList.FormattingEnabled = true;
			this.lbList.ItemHeight = 15;
			this.lbList.Location = new System.Drawing.Point(410, 12);
			this.lbList.Name = "lbList";
			this.lbList.ScrollAlwaysVisible = true;
			this.lbList.Size = new System.Drawing.Size(293, 154);
			this.lbList.TabIndex = 12;
			// 
			// cb順位数
			// 
			this.cb順位数.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cb順位数.FormattingEnabled = true;
			this.cb順位数.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "5",
            "10",
            "20",
            "30",
            "50",
            "100"});
			this.cb順位数.Location = new System.Drawing.Point(717, 12);
			this.cb順位数.Name = "cb順位数";
			this.cb順位数.Size = new System.Drawing.Size(39, 20);
			this.cb順位数.TabIndex = 16;
			this.cb順位数.Text = "10";
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(762, 15);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(36, 12);
			this.label5.TabIndex = 0;
			this.label5.Text = "位まで";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 15);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(77, 12);
			this.label6.TabIndex = 0;
			this.label6.Text = "装備以外重量";
			// 
			// tb装備以外重量
			// 
			this.tb装備以外重量.Location = new System.Drawing.Point(95, 12);
			this.tb装備以外重量.Name = "tb装備以外重量";
			this.tb装備以外重量.Size = new System.Drawing.Size(48, 19);
			this.tb装備以外重量.TabIndex = 3;
			this.tb装備以外重量.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// rb兜全て
			// 
			this.rb兜全て.AutoSize = true;
			this.rb兜全て.Checked = true;
			this.rb兜全て.Location = new System.Drawing.Point(13, 18);
			this.rb兜全て.Name = "rb兜全て";
			this.rb兜全て.Size = new System.Drawing.Size(44, 16);
			this.rb兜全て.TabIndex = 0;
			this.rb兜全て.TabStop = true;
			this.rb兜全て.Text = "全て";
			this.rb兜全て.UseVisualStyleBackColor = true;
			this.rb兜全て.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.cb寵愛);
			this.groupBox3.Controls.Add(this.cbハベルの指輪);
			this.groupBox3.Location = new System.Drawing.Point(14, 70);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(226, 46);
			this.groupBox3.TabIndex = 8;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "指輪";
			// 
			// cb寵愛
			// 
			this.cb寵愛.AutoSize = true;
			this.cb寵愛.Location = new System.Drawing.Point(6, 18);
			this.cb寵愛.Name = "cb寵愛";
			this.cb寵愛.Size = new System.Drawing.Size(114, 16);
			this.cb寵愛.TabIndex = 0;
			this.cb寵愛.Text = "寵愛と加護の指輪";
			this.cb寵愛.UseVisualStyleBackColor = true;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.cb兜);
			this.groupBox4.Controls.Add(this.rb兜固定);
			this.groupBox4.Controls.Add(this.rb兜なし);
			this.groupBox4.Controls.Add(this.rb兜全て);
			this.groupBox4.Location = new System.Drawing.Point(14, 122);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(390, 47);
			this.groupBox4.TabIndex = 10;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "兜";
			// 
			// cb兜
			// 
			this.cb兜.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb兜.FormattingEnabled = true;
			this.cb兜.Location = new System.Drawing.Point(159, 17);
			this.cb兜.Name = "cb兜";
			this.cb兜.Size = new System.Drawing.Size(225, 20);
			this.cb兜.TabIndex = 3;
			// 
			// rb兜固定
			// 
			this.rb兜固定.AutoSize = true;
			this.rb兜固定.Location = new System.Drawing.Point(109, 18);
			this.rb兜固定.Name = "rb兜固定";
			this.rb兜固定.Size = new System.Drawing.Size(47, 16);
			this.rb兜固定.TabIndex = 2;
			this.rb兜固定.Text = "固定";
			this.rb兜固定.UseVisualStyleBackColor = true;
			this.rb兜固定.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
			// 
			// rb兜なし
			// 
			this.rb兜なし.AutoSize = true;
			this.rb兜なし.Location = new System.Drawing.Point(63, 18);
			this.rb兜なし.Name = "rb兜なし";
			this.rb兜なし.Size = new System.Drawing.Size(42, 16);
			this.rb兜なし.TabIndex = 1;
			this.rb兜なし.Text = "なし";
			this.rb兜なし.UseVisualStyleBackColor = true;
			this.rb兜なし.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.cb鎧);
			this.groupBox2.Controls.Add(this.rb鎧固定);
			this.groupBox2.Controls.Add(this.rb鎧なし);
			this.groupBox2.Controls.Add(this.rb鎧全て);
			this.groupBox2.Location = new System.Drawing.Point(14, 175);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(390, 47);
			this.groupBox2.TabIndex = 11;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "鎧";
			// 
			// cb鎧
			// 
			this.cb鎧.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb鎧.FormattingEnabled = true;
			this.cb鎧.Location = new System.Drawing.Point(159, 17);
			this.cb鎧.Name = "cb鎧";
			this.cb鎧.Size = new System.Drawing.Size(225, 20);
			this.cb鎧.TabIndex = 3;
			// 
			// rb鎧固定
			// 
			this.rb鎧固定.AutoSize = true;
			this.rb鎧固定.Location = new System.Drawing.Point(109, 18);
			this.rb鎧固定.Name = "rb鎧固定";
			this.rb鎧固定.Size = new System.Drawing.Size(47, 16);
			this.rb鎧固定.TabIndex = 2;
			this.rb鎧固定.Text = "固定";
			this.rb鎧固定.UseVisualStyleBackColor = true;
			this.rb鎧固定.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
			// 
			// rb鎧なし
			// 
			this.rb鎧なし.AutoSize = true;
			this.rb鎧なし.Location = new System.Drawing.Point(63, 18);
			this.rb鎧なし.Name = "rb鎧なし";
			this.rb鎧なし.Size = new System.Drawing.Size(42, 16);
			this.rb鎧なし.TabIndex = 1;
			this.rb鎧なし.Text = "なし";
			this.rb鎧なし.UseVisualStyleBackColor = true;
			this.rb鎧なし.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
			// 
			// rb鎧全て
			// 
			this.rb鎧全て.AutoSize = true;
			this.rb鎧全て.Checked = true;
			this.rb鎧全て.Location = new System.Drawing.Point(13, 18);
			this.rb鎧全て.Name = "rb鎧全て";
			this.rb鎧全て.Size = new System.Drawing.Size(44, 16);
			this.rb鎧全て.TabIndex = 0;
			this.rb鎧全て.TabStop = true;
			this.rb鎧全て.Text = "全て";
			this.rb鎧全て.UseVisualStyleBackColor = true;
			this.rb鎧全て.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.cb手甲);
			this.groupBox5.Controls.Add(this.rb手甲固定);
			this.groupBox5.Controls.Add(this.rb手甲なし);
			this.groupBox5.Controls.Add(this.rb手甲全て);
			this.groupBox5.Location = new System.Drawing.Point(14, 228);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(390, 47);
			this.groupBox5.TabIndex = 12;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "手甲";
			// 
			// cb手甲
			// 
			this.cb手甲.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb手甲.FormattingEnabled = true;
			this.cb手甲.Location = new System.Drawing.Point(159, 17);
			this.cb手甲.Name = "cb手甲";
			this.cb手甲.Size = new System.Drawing.Size(225, 20);
			this.cb手甲.TabIndex = 3;
			// 
			// rb手甲固定
			// 
			this.rb手甲固定.AutoSize = true;
			this.rb手甲固定.Location = new System.Drawing.Point(109, 18);
			this.rb手甲固定.Name = "rb手甲固定";
			this.rb手甲固定.Size = new System.Drawing.Size(47, 16);
			this.rb手甲固定.TabIndex = 2;
			this.rb手甲固定.Text = "固定";
			this.rb手甲固定.UseVisualStyleBackColor = true;
			this.rb手甲固定.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
			// 
			// rb手甲なし
			// 
			this.rb手甲なし.AutoSize = true;
			this.rb手甲なし.Location = new System.Drawing.Point(63, 18);
			this.rb手甲なし.Name = "rb手甲なし";
			this.rb手甲なし.Size = new System.Drawing.Size(42, 16);
			this.rb手甲なし.TabIndex = 1;
			this.rb手甲なし.Text = "なし";
			this.rb手甲なし.UseVisualStyleBackColor = true;
			this.rb手甲なし.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
			// 
			// rb手甲全て
			// 
			this.rb手甲全て.AutoSize = true;
			this.rb手甲全て.Checked = true;
			this.rb手甲全て.Location = new System.Drawing.Point(13, 18);
			this.rb手甲全て.Name = "rb手甲全て";
			this.rb手甲全て.Size = new System.Drawing.Size(44, 16);
			this.rb手甲全て.TabIndex = 0;
			this.rb手甲全て.TabStop = true;
			this.rb手甲全て.Text = "全て";
			this.rb手甲全て.UseVisualStyleBackColor = true;
			this.rb手甲全て.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.cb足甲);
			this.groupBox6.Controls.Add(this.rb足甲固定);
			this.groupBox6.Controls.Add(this.rb足甲なし);
			this.groupBox6.Controls.Add(this.rb足甲全て);
			this.groupBox6.Location = new System.Drawing.Point(14, 281);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(390, 47);
			this.groupBox6.TabIndex = 13;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "足甲";
			// 
			// cb足甲
			// 
			this.cb足甲.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb足甲.FormattingEnabled = true;
			this.cb足甲.Location = new System.Drawing.Point(159, 17);
			this.cb足甲.Name = "cb足甲";
			this.cb足甲.Size = new System.Drawing.Size(225, 20);
			this.cb足甲.TabIndex = 3;
			// 
			// rb足甲固定
			// 
			this.rb足甲固定.AutoSize = true;
			this.rb足甲固定.Location = new System.Drawing.Point(109, 18);
			this.rb足甲固定.Name = "rb足甲固定";
			this.rb足甲固定.Size = new System.Drawing.Size(47, 16);
			this.rb足甲固定.TabIndex = 2;
			this.rb足甲固定.Text = "固定";
			this.rb足甲固定.UseVisualStyleBackColor = true;
			this.rb足甲固定.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
			// 
			// rb足甲なし
			// 
			this.rb足甲なし.AutoSize = true;
			this.rb足甲なし.Location = new System.Drawing.Point(63, 18);
			this.rb足甲なし.Name = "rb足甲なし";
			this.rb足甲なし.Size = new System.Drawing.Size(42, 16);
			this.rb足甲なし.TabIndex = 1;
			this.rb足甲なし.Text = "なし";
			this.rb足甲なし.UseVisualStyleBackColor = true;
			this.rb足甲なし.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
			// 
			// rb足甲全て
			// 
			this.rb足甲全て.AutoSize = true;
			this.rb足甲全て.Checked = true;
			this.rb足甲全て.Location = new System.Drawing.Point(13, 18);
			this.rb足甲全て.Name = "rb足甲全て";
			this.rb足甲全て.Size = new System.Drawing.Size(44, 16);
			this.rb足甲全て.TabIndex = 0;
			this.rb足甲全て.TabStop = true;
			this.rb足甲全て.Text = "全て";
			this.rb足甲全て.UseVisualStyleBackColor = true;
			this.rb足甲全て.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
			// 
			// MainForm
			// 
			this.AcceptButton = this.brnCalc;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(804, 334);
			this.Controls.Add(this.groupBox6);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.cb順位数);
			this.Controls.Add(this.lbList);
			this.Controls.Add(this.tb結果);
			this.Controls.Add(this.tb装備以外重量);
			this.Controls.Add(this.tb装備重量);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.cb持久力);
			this.Controls.Add(this.cb割合);
			this.Controls.Add(this.cb原盤);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.brnCalc);
			this.Controls.Add(this.btnOption);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.MinimumSize = new System.Drawing.Size(543, 300);
			this.Name = "MainForm";
			this.Text = "ダークソウル 防具シミュレータ";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnOption;
		private System.Windows.Forms.CheckBox cbハベルの指輪;
		private System.Windows.Forms.ComboBox cb割合;
		private System.Windows.Forms.ComboBox cb持久力;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox cb不可;
		private System.Windows.Forms.CheckBox cb光;
		private System.Windows.Forms.CheckBox cb通常;
		private System.Windows.Forms.TextBox tb装備重量;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox cb原盤;
		private System.Windows.Forms.TextBox tb結果;
		private System.Windows.Forms.Button brnCalc;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.ListBox lbList;
		private System.Windows.Forms.ComboBox cb順位数;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox tb装備以外重量;
		private System.Windows.Forms.RadioButton rb兜全て;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.CheckBox cb寵愛;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.ComboBox cb兜;
		private System.Windows.Forms.RadioButton rb兜固定;
		private System.Windows.Forms.RadioButton rb兜なし;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ComboBox cb鎧;
		private System.Windows.Forms.RadioButton rb鎧固定;
		private System.Windows.Forms.RadioButton rb鎧なし;
		private System.Windows.Forms.RadioButton rb鎧全て;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.ComboBox cb手甲;
		private System.Windows.Forms.RadioButton rb手甲固定;
		private System.Windows.Forms.RadioButton rb手甲なし;
		private System.Windows.Forms.RadioButton rb手甲全て;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.ComboBox cb足甲;
		private System.Windows.Forms.RadioButton rb足甲固定;
		private System.Windows.Forms.RadioButton rb足甲なし;
		private System.Windows.Forms.RadioButton rb足甲全て;
	}
}

