namespace _158247_Assignment_4
{
    partial class FormStatistics
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblMostCommon = new System.Windows.Forms.Label();
            this.lblLongestWords = new System.Windows.Forms.Label();
            this.lblShortestWords = new System.Windows.Forms.Label();
            this.lblAvgWordLen = new System.Windows.Forms.Label();
            this.lblSearchWord = new System.Windows.Forms.Label();
            this.lblSearchLength = new System.Windows.Forms.Label();
            this.txtbMostCommon = new System.Windows.Forms.TextBox();
            this.txtbLongestWord = new System.Windows.Forms.TextBox();
            this.txtbShortestWords = new System.Windows.Forms.TextBox();
            this.txtbAvgLen = new System.Windows.Forms.TextBox();
            this.txtbSearchWordDisplay = new System.Windows.Forms.TextBox();
            this.txtbSearchLenDisplay = new System.Windows.Forms.TextBox();
            this.txtbSearchWord = new System.Windows.Forms.TextBox();
            this.txtbSearchLen = new System.Windows.Forms.TextBox();
            this.btnSearchWord = new System.Windows.Forms.Button();
            this.btnSearchLen = new System.Windows.Forms.Button();
            this.txtbDisplayUnique = new System.Windows.Forms.TextBox();
            this.lblUniqueWords = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.lblAbsoluteNumberStats = new System.Windows.Forms.Label();
            this.chartWords = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartWords)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMostCommon
            // 
            this.lblMostCommon.AutoSize = true;
            this.lblMostCommon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostCommon.Location = new System.Drawing.Point(20, 28);
            this.lblMostCommon.Name = "lblMostCommon";
            this.lblMostCommon.Size = new System.Drawing.Size(136, 17);
            this.lblMostCommon.TabIndex = 0;
            this.lblMostCommon.Text = "Most common words";
            // 
            // lblLongestWords
            // 
            this.lblLongestWords.AutoSize = true;
            this.lblLongestWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLongestWords.Location = new System.Drawing.Point(20, 101);
            this.lblLongestWords.Name = "lblLongestWords";
            this.lblLongestWords.Size = new System.Drawing.Size(100, 17);
            this.lblLongestWords.TabIndex = 1;
            this.lblLongestWords.Text = "Longest words";
            // 
            // lblShortestWords
            // 
            this.lblShortestWords.AutoSize = true;
            this.lblShortestWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShortestWords.Location = new System.Drawing.Point(20, 170);
            this.lblShortestWords.Name = "lblShortestWords";
            this.lblShortestWords.Size = new System.Drawing.Size(102, 17);
            this.lblShortestWords.TabIndex = 2;
            this.lblShortestWords.Text = "Shortest words";
            // 
            // lblAvgWordLen
            // 
            this.lblAvgWordLen.AutoSize = true;
            this.lblAvgWordLen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgWordLen.Location = new System.Drawing.Point(20, 240);
            this.lblAvgWordLen.Name = "lblAvgWordLen";
            this.lblAvgWordLen.Size = new System.Drawing.Size(138, 17);
            this.lblAvgWordLen.TabIndex = 3;
            this.lblAvgWordLen.Text = "Average word length";
            // 
            // lblSearchWord
            // 
            this.lblSearchWord.AutoSize = true;
            this.lblSearchWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchWord.Location = new System.Drawing.Point(495, 26);
            this.lblSearchWord.Name = "lblSearchWord";
            this.lblSearchWord.Size = new System.Drawing.Size(87, 17);
            this.lblSearchWord.TabIndex = 4;
            this.lblSearchWord.Text = "Search word";
            // 
            // lblSearchLength
            // 
            this.lblSearchLength.AutoSize = true;
            this.lblSearchLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchLength.Location = new System.Drawing.Point(495, 101);
            this.lblSearchLength.Name = "lblSearchLength";
            this.lblSearchLength.Size = new System.Drawing.Size(96, 17);
            this.lblSearchLength.TabIndex = 5;
            this.lblSearchLength.Text = "Search length";
            // 
            // txtbMostCommon
            // 
            this.txtbMostCommon.Location = new System.Drawing.Point(162, 28);
            this.txtbMostCommon.Multiline = true;
            this.txtbMostCommon.Name = "txtbMostCommon";
            this.txtbMostCommon.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbMostCommon.Size = new System.Drawing.Size(164, 53);
            this.txtbMostCommon.TabIndex = 6;
            // 
            // txtbLongestWord
            // 
            this.txtbLongestWord.Location = new System.Drawing.Point(162, 100);
            this.txtbLongestWord.Multiline = true;
            this.txtbLongestWord.Name = "txtbLongestWord";
            this.txtbLongestWord.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbLongestWord.Size = new System.Drawing.Size(164, 53);
            this.txtbLongestWord.TabIndex = 7;
            // 
            // txtbShortestWords
            // 
            this.txtbShortestWords.Location = new System.Drawing.Point(162, 169);
            this.txtbShortestWords.Multiline = true;
            this.txtbShortestWords.Name = "txtbShortestWords";
            this.txtbShortestWords.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbShortestWords.Size = new System.Drawing.Size(164, 53);
            this.txtbShortestWords.TabIndex = 8;
            // 
            // txtbAvgLen
            // 
            this.txtbAvgLen.Location = new System.Drawing.Point(162, 239);
            this.txtbAvgLen.Multiline = true;
            this.txtbAvgLen.Name = "txtbAvgLen";
            this.txtbAvgLen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbAvgLen.Size = new System.Drawing.Size(164, 53);
            this.txtbAvgLen.TabIndex = 9;
            // 
            // txtbSearchWordDisplay
            // 
            this.txtbSearchWordDisplay.Location = new System.Drawing.Point(703, 26);
            this.txtbSearchWordDisplay.Multiline = true;
            this.txtbSearchWordDisplay.Name = "txtbSearchWordDisplay";
            this.txtbSearchWordDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbSearchWordDisplay.Size = new System.Drawing.Size(164, 53);
            this.txtbSearchWordDisplay.TabIndex = 10;
            // 
            // txtbSearchLenDisplay
            // 
            this.txtbSearchLenDisplay.Location = new System.Drawing.Point(703, 100);
            this.txtbSearchLenDisplay.Multiline = true;
            this.txtbSearchLenDisplay.Name = "txtbSearchLenDisplay";
            this.txtbSearchLenDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbSearchLenDisplay.Size = new System.Drawing.Size(164, 53);
            this.txtbSearchLenDisplay.TabIndex = 11;
            // 
            // txtbSearchWord
            // 
            this.txtbSearchWord.Location = new System.Drawing.Point(597, 26);
            this.txtbSearchWord.Name = "txtbSearchWord";
            this.txtbSearchWord.Size = new System.Drawing.Size(100, 20);
            this.txtbSearchWord.TabIndex = 12;
            // 
            // txtbSearchLen
            // 
            this.txtbSearchLen.Location = new System.Drawing.Point(597, 100);
            this.txtbSearchLen.Name = "txtbSearchLen";
            this.txtbSearchLen.Size = new System.Drawing.Size(100, 20);
            this.txtbSearchLen.TabIndex = 13;
            // 
            // btnSearchWord
            // 
            this.btnSearchWord.Location = new System.Drawing.Point(597, 58);
            this.btnSearchWord.Name = "btnSearchWord";
            this.btnSearchWord.Size = new System.Drawing.Size(75, 23);
            this.btnSearchWord.TabIndex = 14;
            this.btnSearchWord.Text = "Search";
            this.btnSearchWord.UseVisualStyleBackColor = true;
            this.btnSearchWord.Click += new System.EventHandler(this.btnSearchWordClick);
            // 
            // btnSearchLen
            // 
            this.btnSearchLen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchLen.Location = new System.Drawing.Point(597, 130);
            this.btnSearchLen.Name = "btnSearchLen";
            this.btnSearchLen.Size = new System.Drawing.Size(75, 23);
            this.btnSearchLen.TabIndex = 15;
            this.btnSearchLen.Text = "Search";
            this.btnSearchLen.UseVisualStyleBackColor = true;
            this.btnSearchLen.Click += new System.EventHandler(this.BtnSearchLenClick);
            // 
            // txtbDisplayUnique
            // 
            this.txtbDisplayUnique.Location = new System.Drawing.Point(466, 203);
            this.txtbDisplayUnique.Multiline = true;
            this.txtbDisplayUnique.Name = "txtbDisplayUnique";
            this.txtbDisplayUnique.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbDisplayUnique.Size = new System.Drawing.Size(401, 195);
            this.txtbDisplayUnique.TabIndex = 16;
            // 
            // lblUniqueWords
            // 
            this.lblUniqueWords.AutoSize = true;
            this.lblUniqueWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUniqueWords.Location = new System.Drawing.Point(495, 183);
            this.lblUniqueWords.Name = "lblUniqueWords";
            this.lblUniqueWords.Size = new System.Drawing.Size(134, 17);
            this.lblUniqueWords.TabIndex = 17;
            this.lblUniqueWords.Text = "List of unique words";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(879, 27);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(41, 23);
            this.fileMenuItem.Text = "File";
            this.fileMenuItem.Click += new System.EventHandler(this.fileMenuItemClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMessage.Location = new System.Drawing.Point(32, 307);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(0, 20);
            this.lblErrorMessage.TabIndex = 19;
            // 
            // lblAbsoluteNumberStats
            // 
            this.lblAbsoluteNumberStats.AutoSize = true;
            this.lblAbsoluteNumberStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbsoluteNumberStats.Location = new System.Drawing.Point(20, 407);
            this.lblAbsoluteNumberStats.Name = "lblAbsoluteNumberStats";
            this.lblAbsoluteNumberStats.Size = new System.Drawing.Size(0, 15);
            this.lblAbsoluteNumberStats.TabIndex = 20;
            // 
            // chartWords
            // 
            chartArea1.Name = "Words";
            this.chartWords.ChartAreas.Add(chartArea1);
            legend1.IsEquallySpacedItems = true;
            legend1.Name = "Legend1";
            legend1.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
            this.chartWords.Legends.Add(legend1);
            this.chartWords.Location = new System.Drawing.Point(12, 429);
            this.chartWords.Name = "chartWords";
            series1.ChartArea = "Words";
            series1.EmptyPointStyle.IsValueShownAsLabel = true;
            series1.LabelAngle = 90;
            series1.Legend = "Legend1";
            series1.Name = "Words";
            this.chartWords.Series.Add(series1);
            this.chartWords.Size = new System.Drawing.Size(855, 253);
            this.chartWords.TabIndex = 21;
            this.chartWords.Text = "words";
            // 
            // FormStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(879, 686);
            this.Controls.Add(this.chartWords);
            this.Controls.Add(this.lblAbsoluteNumberStats);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.lblUniqueWords);
            this.Controls.Add(this.txtbDisplayUnique);
            this.Controls.Add(this.btnSearchLen);
            this.Controls.Add(this.btnSearchWord);
            this.Controls.Add(this.txtbSearchLen);
            this.Controls.Add(this.txtbSearchWord);
            this.Controls.Add(this.txtbSearchLenDisplay);
            this.Controls.Add(this.txtbSearchWordDisplay);
            this.Controls.Add(this.txtbAvgLen);
            this.Controls.Add(this.txtbShortestWords);
            this.Controls.Add(this.txtbLongestWord);
            this.Controls.Add(this.txtbMostCommon);
            this.Controls.Add(this.lblSearchLength);
            this.Controls.Add(this.lblSearchWord);
            this.Controls.Add(this.lblAvgWordLen);
            this.Controls.Add(this.lblShortestWords);
            this.Controls.Add(this.lblLongestWords);
            this.Controls.Add(this.lblMostCommon);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormStatistics";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartWords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMostCommon;
        private System.Windows.Forms.Label lblLongestWords;
        private System.Windows.Forms.Label lblShortestWords;
        private System.Windows.Forms.Label lblAvgWordLen;
        private System.Windows.Forms.Label lblSearchWord;
        private System.Windows.Forms.Label lblSearchLength;
        private System.Windows.Forms.TextBox txtbMostCommon;
        private System.Windows.Forms.TextBox txtbLongestWord;
        private System.Windows.Forms.TextBox txtbShortestWords;
        private System.Windows.Forms.TextBox txtbAvgLen;
        private System.Windows.Forms.TextBox txtbSearchWordDisplay;
        private System.Windows.Forms.TextBox txtbSearchLenDisplay;
        private System.Windows.Forms.TextBox txtbSearchWord;
        private System.Windows.Forms.TextBox txtbSearchLen;
        private System.Windows.Forms.Button btnSearchWord;
        private System.Windows.Forms.Button btnSearchLen;
        private System.Windows.Forms.TextBox txtbDisplayUnique;
        private System.Windows.Forms.Label lblUniqueWords;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.Label lblAbsoluteNumberStats;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartWords;
    }
}

